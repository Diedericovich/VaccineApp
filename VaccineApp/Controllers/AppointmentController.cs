using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VaccineApp.Services;

namespace VaccineApp.Controllers
{
    [ApiController, Authorize, Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        [HttpPost("{userId}/{vaccineId}")]
        public async Task<ActionResult> AddAppointmentAsync(int userId, int vaccineId)
        {
            if (await _service.UserHasVaccine(userId, vaccineId))
            {
                return BadRequest("You already have this vaccination or already have another appointment for it scheduled.");
            }
            try
            {
                await _service.AddAppointmentAsync(userId, vaccineId);
                return Ok("Appointment Created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{appointmentId}/{statusId}")]
        public async Task<ActionResult> UpdateAppointmentStatusAsync(int appointmentId, int statusId)
        {
            if (!await _service.AppointmentExists(appointmentId))
            {
                return BadRequest("Appointment not Found");
            }
            else if (statusId < 1 || statusId > 3)
            {
                return BadRequest("Invalid appointment status");
            }
            await _service.UpdateAppointmentStatusAsync(appointmentId, statusId);
            return Ok("Update OK");
        }
    }
}
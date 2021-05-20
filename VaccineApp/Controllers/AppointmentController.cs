using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VaccineApp.Services;

namespace VaccineApp.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        [HttpPost("{userId}/{vaccineId}")]
        public async Task AddAppointmentAsync(int userId, int vaccineId)
        {
            await _service.AddAppointmentAsync(userId, vaccineId);
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
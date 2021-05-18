namespace VaccineApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DTO;

    using Entities;

    using Microsoft.AspNetCore.Mvc;

    using Repositories;

    using Services;

    [ApiController, Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _service.AddAppointmentAsync(appointment);
        }

        [HttpDelete("{id:int})")]
        public async Task<ActionResult> DeleteAppointmentAsync(int id)
        {
            await _service.DeleteAppointmentAsync(id);
            return Ok("Delete OK");
        }

        [HttpGet("{id:int}")]
        public async Task<AppointmentDto> GetAppointmentAsync(int id)
        {
            return await _service.GetAppointmentAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<AppointmentDto>> GetAppointmentsAsync()
        {
            return await _service.GetAppointmentsAsync();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAppointmentAsync(Appointment appointment)
        {
            await _service.UpdateAppointmentAsync(appointment);
            return Ok("Update OK");
        }
    }
}
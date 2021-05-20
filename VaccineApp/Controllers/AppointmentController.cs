﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccineApp.DTO;
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
        public async Task UpdateAppointmentStatusAsync(int appointmentId, int statusId)
        {
            await _service.UpdateAppointmentStatusAsync(appointmentId, statusId);
        }
    }
}
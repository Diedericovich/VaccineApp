﻿using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.DTO;
using VaccineApp.Entities;

namespace VaccineApp.Services
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(int userId, int vaccineId);
        Task<bool> AppointmentExists(int appointmentId);
        Task DeleteAppointmentAsync(int id);
        Task<AppointmentDto> GetAppointmentAsync(int id);
        Task<List<AppointmentDto>> GetAppointmentsAsync();
        Task UpdateAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentStatusAsync(int appointmentId, int status);
        Task<bool> UserHasVaccine(int userId, int vaccineId);
    }
}
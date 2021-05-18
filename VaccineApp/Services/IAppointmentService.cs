namespace VaccineApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DTO;
    using Entities;

    public interface IAppointmentService
    {
        Task AddAppointmentAsync(Appointment appointment);

        Task DeleteAppointmentAsync(int id);

        Task<List<AppointmentDto>> GetAppointmentsAsync();

        Task<AppointmentDto> GetAppointmentAsync(int id);

        Task UpdateAppointmentAsync(Appointment appointment);
    }
}
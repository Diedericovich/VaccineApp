namespace VaccineApp.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IAppointmentRepo
    {
        Task<Appointment> GetAppointmentAsync(int id);
        Task<List<Appointment>> GetAppointmentsAsync();
        Task AddAppointmentAsync(Appointment appointment);
        Task DeleteAppointmentAsync(int id);
        Task UpdateAppointmentAsync(Appointment appointment);
    }
}
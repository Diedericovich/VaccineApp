using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    public interface IAppointmentRepo
    {
        Task<bool> AppointmentExists(int id);
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment> GetAsync(int id);
        Task AddAsync(Appointment appointment);
        Task DeleteAsync(int id);
        Task UpdateAsync(Appointment appointment);
    }
}
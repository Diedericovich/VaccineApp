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
        Task UpdateAsync(Appointment item);
        Task<bool> UserHasVaccine(int userId, int vaccineId);
        Task DeleteAsync(int id);
        Task AddAsync(Appointment appointment);
    }
}
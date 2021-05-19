using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    public interface IVaccineRepo
    {
        Task<List<Vaccine>> GetAllAsync();

        Task<List<Vaccine>> GetAllByPartAsync(string part);

        Task<Vaccine> GetAsync(int id);

        Task AddAsync(Vaccine vaccine);

        Task DeleteAsync(int id);

        Task UpdateAsync(Vaccine vaccine);
    }
}
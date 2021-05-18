namespace VaccineApp.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IVaccineRepo
    {
        Task AddVaccineAsync(Vaccine vaccine);
        Task DeleteVaccineAsync(int id);
        Task<Vaccine> GetVaccineAsync(int id);
        Task<List<Vaccine>> GetVaccinesAsync();
        Task UpdateVaccineAsync(Vaccine vaccine);
    }
}
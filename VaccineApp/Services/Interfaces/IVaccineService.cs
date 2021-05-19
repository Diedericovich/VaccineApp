namespace VaccineApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DTO;
    using Entities;

    public interface IVaccineService
    {
        Task AddVaccineAsync(Vaccine vaccine);
        Task DeleteVaccineAsync(int id);
        Task<List<VaccineDto>> GetVaccinesAsync();
        Task UpdateVaccineAsync(Vaccine vaccine);
        Task<VaccineDto> GetVaccineAsync(int id);
        Task<IEnumerable<VaccineDto>> GetVaccinesAsyncByPartAsync(string bodypart);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Services
{
    public interface IVaccinationCenterService
    {
        Task<List<VaccinationCenter>> GetVaccinationCentersAsync();
    }
}
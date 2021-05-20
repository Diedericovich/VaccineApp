using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;

namespace VaccineApp.Repositories
{
    public interface IVaccinationCenterRepo
    {
        Task<List<VaccinationCenter>> GetRandomItem(int amount);
    }
}
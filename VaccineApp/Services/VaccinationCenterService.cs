using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;
using VaccineApp.Repositories;

namespace VaccineApp.Services
{
    public class VaccinationCenterService : IVaccinationCenterService
    {
        private IGenericRepo<VaccinationCenter> _repo;

        public VaccinationCenterService(IGenericRepo<VaccinationCenter> repo)
        {
            _repo = repo;
        }

        public async Task<List<VaccinationCenter>> GetVaccinationCentersAsync()
        {
            List<VaccinationCenter> resultList = await _repo.GetAllAsync();
            return resultList;
        }
    }
}
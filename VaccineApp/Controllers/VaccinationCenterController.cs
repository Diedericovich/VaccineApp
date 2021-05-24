using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VaccineApp.Entities;
using VaccineApp.Services;

namespace VaccineApp.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class VaccinationCenterController
    {
        private IVaccinationCenterService _service;

        public VaccinationCenterController(IVaccinationCenterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<VaccinationCenter>> GetVaccinationCentersAsync()
        {
            return await _service.GetVaccinationCentersAsync();
        }
    }
}
namespace VaccineApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DTO;

    using Entities;

    using Microsoft.AspNetCore.Mvc;

    using Services;

    [ApiController, Route("api/[controller]")]
    public class VaccineController : ControllerBase
    {
        private IVaccineService _service;

        public VaccineController(IVaccineService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task AddVaccineAsync(Vaccine vaccine)
        {
            await _service.AddVaccineAsync(vaccine);
        }

        [HttpDelete("{id:int})")]
        public async Task<ActionResult> DeleteVaccineAsync(int id)
        {
            await _service.DeleteVaccineAsync(id);
            return Ok("Delete OK");
        }

        [HttpGet("{id:int}")]
        public async Task<VaccineDto> GetVaccineAsync(int id)
        {
            return await _service.GetVaccineAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<VaccineDto>> GetVaccinesAsync()
        {
            return await _service.GetVaccinesAsync();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateVaccineAsync(Vaccine vaccine)
        {
            await _service.UpdateVaccineAsync(vaccine);
            return Ok("Update OK");
        }
    }
}
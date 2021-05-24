namespace VaccineApp.Controllers
{
    using DTO;
    using Entities;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController, Authorize, Route("api/[controller]")]
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

        [HttpDelete("{id})")]
        public async Task<ActionResult> DeleteVaccineAsync(int id)
        {
            await _service.DeleteVaccineAsync(id);
            return Ok("Delete OK");
        }

        [HttpGet("{id}"), AllowAnonymous]
        public async Task<VaccineDto> GetVaccineAsync(int id)
        {
            return await _service.GetVaccineAsync(id);
        }

        [HttpGet, AllowAnonymous]
        public async Task<IEnumerable<VaccineDto>> GetVaccinesAsync()
        {
            return await _service.GetVaccinesAsync();
        }

        [HttpGet("ForBodyPart/{bodypart}"), AllowAnonymous]
        public async Task<IEnumerable<VaccineDto>> GetVaccinesByPartAsync(string bodypart)
        {
            return await _service.GetVaccinesAsyncByPartAsync(bodypart);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateVaccineAsync(Vaccine vaccine)
        {
            await _service.UpdateVaccineAsync(vaccine);
            return Ok("Update OK");
        }
    }
}
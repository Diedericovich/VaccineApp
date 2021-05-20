using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccineApp.DTO;
using VaccineApp.Services;

namespace VaccineApp.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class LocationController
    {
        private IGeoCodeService _service;

        public LocationController(IGeoCodeService service)
        {
            _service = service;
        }

        [HttpGet("{address}")]
        public Task<LocationDto> GetLocation(string address)
        {
            return _service.GetLocation(address);
        }
    }
}
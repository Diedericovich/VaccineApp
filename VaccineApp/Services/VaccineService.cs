namespace VaccineApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection.PortableExecutable;
    using System.Threading.Tasks;

    using AutoMapper;

    using DTO;

    using Entities;

    using Repositories;

    public class VaccineService : IVaccineService
    {
        private IMapper _mapper;

        private IVaccineRepo _vaccineRepo;

        public VaccineService(IVaccineRepo vaccineRepo, IMapper mapper)
        {
            _vaccineRepo = vaccineRepo;
            _mapper = mapper;
        }

        public async Task AddVaccineAsync(Vaccine vaccine)
        {
            await _vaccineRepo.AddVaccineAsync(vaccine);
        }

        public async Task DeleteVaccineAsync(int id)
        {
            await _vaccineRepo.DeleteVaccineAsync(id);
        }

        public async Task<List<VaccineDto>> GetVaccinesAsync()
        {
            List<Vaccine> vaccineList = await _vaccineRepo.GetVaccinesAsync();
            List<VaccineDto> resultList = _mapper.Map<List<VaccineDto>>(vaccineList);
            return resultList;
        }

        public async Task UpdateVaccineAsync(Vaccine vaccine)
        {
            await _vaccineRepo.UpdateVaccineAsync(vaccine);
        }

        public async Task<VaccineDto> GetVaccineAsync(int id)
        {
            Vaccine vaccine = await _vaccineRepo.GetVaccineAsync(id);
            VaccineDto result = _mapper.Map<VaccineDto>(vaccine);
            return result;
        }
    }
}
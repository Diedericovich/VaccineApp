namespace VaccineApp.Services
{
    using AutoMapper;
    using DTO;
    using Entities;
    using Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

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
            await _vaccineRepo.AddAsync(vaccine);
        }

        public async Task DeleteVaccineAsync(int id)
        {
            await _vaccineRepo.DeleteAsync(id);
        }

        public async Task<List<VaccineDto>> GetVaccinesAsync()
        {
            List<Vaccine> vaccineList = await _vaccineRepo.GetAllAsync();
            List<VaccineDto> resultList = _mapper.Map<List<VaccineDto>>(vaccineList);
            return resultList;
        }

        public async Task UpdateVaccineAsync(Vaccine vaccine)
        {
            await _vaccineRepo.UpdateAsync(vaccine);
        }

        public async Task<VaccineDto> GetVaccineAsync(int id)
        {
            Vaccine vaccine = await _vaccineRepo.GetAsync(id);
            VaccineDto result = _mapper.Map<VaccineDto>(vaccine);
            return result;
        }

        public async Task<IEnumerable<VaccineDto>> GetVaccinesAsyncByPartAsync(string bodypart)
        {
            if (bodypart == "Head")
            {
                List<VaccineDto> resultList = _mapper.Map<List<VaccineDto>>(await _vaccineRepo.GetAllByPartAsync("Head"));
                return resultList;
            }
            else
            {
                List<VaccineDto> resultList = _mapper.Map<List<VaccineDto>>(await _vaccineRepo.GetAllByPartAsync(bodypart));
                return resultList;
            }
        }
    }
}
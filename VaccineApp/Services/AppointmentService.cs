namespace VaccineApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using DTO;

    using Entities;

    using Repositories;

    public class AppointmentService : IAppointmentService
    {
        private IGenericRepo<Appointment> _appointmentRepo;
        private IGenericRepo<Vaccine> _vaccineRepo;
        private IVaccinationCenterRepo _centerRepo;
        private IMapper _mapper;

        public AppointmentService(IGenericRepo<Appointment> appointmentRepo, IGenericRepo<Vaccine> vaccineRepo, IVaccinationCenterRepo centerRepo, IMapper mapper)
        {
            _appointmentRepo = appointmentRepo;
            _vaccineRepo = vaccineRepo;
            _centerRepo = centerRepo;
            _mapper = mapper;
        }

        public async Task AddAppointmentAsync(int userId, int vaccineId)
        {
            Vaccine vaccine = await _vaccineRepo.GetAsync(vaccineId);
            var location = await _centerRepo.GetRandomItem(1);
            Appointment appointment = new Appointment
            {
                Vaccination = vaccine,
                UserId = userId,
                Date = DateTime.Now.AddDays(7),
                LocationId = location[0].Id,
                StatusId = 1
            };
            await _appointmentRepo.AddAsync(appointment);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            await _appointmentRepo.DeleteAsync(id);
        }

        public async Task<List<AppointmentDto>> GetAppointmentsAsync()
        {
            List<Appointment> appointmentList = await _appointmentRepo.GetAllAsync();
            List<AppointmentDto> resultList = _mapper.Map<List<AppointmentDto>>(appointmentList);
            return resultList;
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepo.UpdateAsync(appointment);
        }

        public async Task<AppointmentDto> GetAppointmentAsync(int id)
        {
            Appointment appointment = await _appointmentRepo.GetAsync(id);
            AppointmentDto result = _mapper.Map<AppointmentDto>(appointment);
            return result;
        }
    }
}
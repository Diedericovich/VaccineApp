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
        private IAppointmentRepo _appointmentRepo;
        private IMapper _mapper;

        public AppointmentService(IAppointmentRepo appointmentRepo, IMapper mapper)
        {
            _appointmentRepo = appointmentRepo;
            _mapper = mapper;
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepo.AddAppointmentAsync(appointment);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
            await _appointmentRepo.DeleteAppointmentAsync(id);
        }

        public async Task<List<AppointmentDto>> GetAppointmentsAsync()
        {
            List<Appointment> appointmentList = await _appointmentRepo.GetAppointmentsAsync();
            List<AppointmentDto> resultList = _mapper.Map<List<AppointmentDto>>(appointmentList);
            return resultList;
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await _appointmentRepo.UpdateAppointmentAsync(appointment);
        }

        public async Task<AppointmentDto> GetAppointmentAsync(int id)
        {
            Appointment appointment = await _appointmentRepo.GetAppointmentAsync(id);
            AppointmentDto result = _mapper.Map<AppointmentDto>(appointment);
            return result;
        }
    }
}
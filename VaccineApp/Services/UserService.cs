namespace VaccineApp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using AutoMapper;
    using DTO;
    using Entities;
    using Repositories;

    public class UserService : IUserService
    {
        private IMapper _mapper;

        private IGenericRepo<User> _userRepo;
        private IGenericRepo<Vaccine> _vaccineRepo;

        public UserService(IGenericRepo<User> userRepo, IGenericRepo<Vaccine> vaccineRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _vaccineRepo = vaccineRepo;
            _mapper = mapper;
        }

        public async Task AddUserAsync(UserDto user)
        {
            await _userRepo.AddAsync(_mapper.Map<User>(user));
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepo.DeleteAsync(id);
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            List<User> userList = await _userRepo.GetAllAsync();
            List<UserDto> resultList = _mapper.Map<List<UserDto>>(userList);
            return resultList;
        }

        public async Task UpdateUserAsync(UserDto user)
        {
            await _userRepo.UpdateAsync(_mapper.Map<User>(user));
        }

        public async Task<UserDto> GetUserAsync(int id)
        {
            User user = await _userRepo.GetAsync(id);
            UserDto result = _mapper.Map<UserDto>(user);
            return result;
        }

        public async Task AddAppointment(UserDto user, int id)
        {
            VaccineDto temp = _mapper.Map<VaccineDto>(await _vaccineRepo.GetAsync(id));
            user.Appointments.Add(new AppointmentDto
            {
                Vaccination = temp,
                Date = DateTime.Now.AddDays(7),
            });
            await UpdateUserAsync(user);
        }
    }
}
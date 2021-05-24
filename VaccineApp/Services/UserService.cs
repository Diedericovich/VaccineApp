namespace VaccineApp.Services
{
    using AutoMapper;
    using DTO;
    using Entities;
    using Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private IMapper _mapper;

        private IUserRepo _userRepo;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
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
            User temp = _mapper.Map<User>(user);
            await _userRepo.UpdateAsync(temp);
        }

        public async Task<UserDto> GetUserAsync(int id)
        {
            User user = await _userRepo.GetAsync(id);
            UserDto result = _mapper.Map<UserDto>(user);
            return result;
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            User user = await _userRepo.GetUserByEmail(email);
            UserDto result = _mapper.Map<UserDto>(user);
            return result;
        }
    }
}
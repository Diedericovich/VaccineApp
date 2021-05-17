﻿namespace VaccineApp.Services
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

        private IUserRepo _userRepo;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public async Task AddUserAsync(User user)
        {
            await _userRepo.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepo.DeleteUserAsync(id);
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            List<User> userList = await _userRepo.GetUsersAsync();
            List<UserDto> resultList = _mapper.Map<List<UserDto>>(userList);
            return resultList;
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepo.UpdateUserAsync(user);
        }

        public async Task<UserDto> GetUserAsync(int id)
        {
            User user = await _userRepo.GetUserAsync(id);
            UserDto result = _mapper.Map<UserDto>(user);
            return result;
        }
    }
}
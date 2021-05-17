using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace VaccineApp.Helpers
{
    using AutoMapper;

    using DTO;

    using Entities;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ForMember(
                destinationMember => destinationMember.Email,
                opt => opt.MapFrom(src => src.Login.EMail));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApp.Helpers
{
    using AutoMapper;

    using VaccineApp.DTO;
    using VaccineApp.Entities;

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
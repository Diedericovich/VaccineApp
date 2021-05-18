namespace VaccineApp.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using DTO;

    using Entities;

    using Microsoft.AspNetCore.Identity;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ForMember(
                destinationMember => destinationMember.Email,
                opt => opt.MapFrom(src => src.Login.Email));
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Vaccine, VaccineDto>()
                .ForMember(dest => dest.BodyPart, opt => opt.MapFrom(src => src.BodyPart.Name))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));
        }
    }
}
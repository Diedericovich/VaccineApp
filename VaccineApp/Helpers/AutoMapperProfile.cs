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
            CreateMap<User, UserDto>()
                .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Login.Email))
                .ForMember(dst => dst.Appointments, opt => opt.MapFrom(src => src.Appointments));
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dst => dst.Vaccination, opt => opt.MapFrom(src => src.Vaccination))
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status));

            CreateMap<Vaccine, VaccineDto>()
                .ForMember(dst => dst.BodyPart, opt => opt.MapFrom(src => src.BodyPart.Name))
                .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            CreateMap<Vaccine, VaccineDto>()
                .ForMember(dst => dst.BodyPart, opt => opt.MapFrom(src => src.BodyPart.Name))
                .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.Company.Name));
        }
    }
}
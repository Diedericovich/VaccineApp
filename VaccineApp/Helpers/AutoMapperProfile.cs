namespace VaccineApp.Helpers
{
    using AutoMapper;

    using DTO;

    using Entities;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dst => dst.Appointments, opt => opt.MapFrom(src => src.Appointments))
                .ReverseMap();

            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dst => dst.Vaccination, opt => opt.MapFrom(src => src.Vaccination))
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => src.Location))
                .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                .ReverseMap();

            CreateMap<Vaccine, VaccineDto>()
                .ForMember(dst => dst.BodyPart, opt => opt.MapFrom(src => src.BodyPart.Name))
                .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.Company.Name))
                .ReverseMap()
                .ForPath(x => x.BodyPart, opt => opt.Ignore());
        }
    }
}
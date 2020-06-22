using AutoMapper;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();
      CreateMap<Entities.Models.Entertainment, EntertainmentDTO>()
              .ForMember(dest => dest.EntertainmentFilePath, opt => opt.MapFrom(src => src.EntertainmentFilePath.Split(';', System.StringSplitOptions.RemoveEmptyEntries)));

      CreateMap<EntertainmentDTO, Entities.Models.Entertainment>()
        .ForMember(dest => dest.EntertainmentFilePath, opt => opt.MapFrom(src => string.Join(';', src.EntertainmentFilePath)));
    }
  }
}

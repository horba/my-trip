using AutoMapper;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();

      CreateMap<Entities.Models.Accommodation, AccommodationDTO>()
        .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Split(';', System.StringSplitOptions.RemoveEmptyEntries)));

      CreateMap<AccommodationDTO, Entities.Models.Accommodation>()
        .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => string.Join(';', src.Photos)));
    }
  }
}

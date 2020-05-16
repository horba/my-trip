using AutoMapper;
using WebAPI.DTO.Trip;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryResponse>();

      CreateMap<Entities.Models.Trip, TripHistoryResponse>();
    }
  }
}

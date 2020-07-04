using AutoMapper;
using Entities.Models;
using WebAPI.DTO.ScheduledPlaceToEat;

namespace WebAPI.Mappers
{
  public class SheduledPlaceToEatMappingProfile : Profile
  {

    public SheduledPlaceToEatMappingProfile()
    {
      CreateMap<ScheduledPlaceToEat, OutputScheduledPlaceToEatDTO>()
        .ForMember("PlaceName", opt => opt.MapFrom(c => c.NamePlace));
      CreateMap<OutputScheduledPlaceToEatDTO, ScheduledPlaceToEat>()
        .ForMember("NamePlace", opt => opt.MapFrom(c => c.PlaceName));
      CreateMap<InputScheduledPlaceToEatForCreateDTO, ScheduledPlaceToEat>()
        .ForMember("NamePlace", opt => opt.MapFrom(c => c.PlaceName));
      CreateMap<InputScheduledPlaceToEatForUpdateDTO, ScheduledPlaceToEat>()
        .ForMember("NamePlace", opt => opt.MapFrom(c => c.PlaceName));
    }
  }
}

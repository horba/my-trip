using System;
using System.Linq;
using AutoMapper;
using Entities.Models;
using WebAPI.DTO.Waypoint;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();

      CreateMap<Entities.Models.Waypoint, WaypointDTO>();

      CreateMap<WaypointRequestDTO, Entities.Models.Waypoint>()
        .ForMember(wp => wp.PathTime, opt => opt.MapFrom(wp => TimeSpan.Parse(wp.PathTime)))
        .ForMember(wp => wp.City, opt => opt.MapFrom(wp => wp.DepartureCity))
        .ForMember(wp => wp.Id, opt => opt.MapFrom(wp => wp.NewId));
    }
  }
}

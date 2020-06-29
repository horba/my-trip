using System;
using System.Linq;
using AutoMapper;
using Entities.Models;
using WebAPI.DTO.Trip;
using WebAPI.DTO.Waypoint;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();

      CreateMap<Entities.Models.Waypoint, WaypointDTO>()
        .ForMember(wp => wp.ArrivalDate, 
        opt => opt.MapFrom(wp => wp.ArrivalDate.ToString("yyyy-MM-ddTHH:mm:ssZ")))
        .ForMember(wp => wp.DepartureDate, 
        opt => opt.MapFrom(wp => wp.DepartureDate.ToString("yyyy-MM-ddTHH:mm:ssZ")));

      CreateMap<WaypointFile, WaypointFileDTO>();

      CreateMap<WaypointRequestDTO, Entities.Models.Waypoint>()
        .ForMember(wp => wp.PathTime, 
        opt => opt.MapFrom(wp => TimeSpan.Parse(wp.PathTime)))
        .ForMember(wp => wp.City, 
        opt => opt.MapFrom(wp => wp.DepartureCity))
        .ForMember(wp => wp.Id, 
        opt => opt.MapFrom(wp => wp.NewId));

      CreateMap<TripRequestDTO, Entities.Models.Trip>()
        .ForMember(tr => tr.StartDate, 
        opt => opt.MapFrom(tr => tr.DepartureDate))
        .ForMember(tr => tr.EndDate, 
        opt => opt.MapFrom(tr => tr.ArrivalDate));

    }
  }
}

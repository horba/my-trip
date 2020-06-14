using System;
using System.Linq;
using AutoMapper;
using Entities.Models;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();

      CreateMap<Waypoint, WaypointDTO>();
    }
  }
}

﻿using AutoMapper;

namespace WebAPI.DTO
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Entities.Models.Country, CountryDTO>();

      CreateMap<Entities.Models.Trip, TripDTO>();
    }
  }
}
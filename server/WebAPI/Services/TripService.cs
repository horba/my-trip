using Entities;
using System;
using System.Collections.Generic;
using AutoMapper;
using WebAPI.DTO;
using System.Linq;

namespace WebAPI.Services
{
  public class TripService
  {
    private readonly IMapper _mapper;
    private readonly TripRepository _tripRepository;

    public TripService(IMapper mapper, TripRepository tripRepository)
    {
      _mapper = mapper;
      _tripRepository = tripRepository;
    }

    public IEnumerable<TripDTO> GetTripsHistory(int userId, string searchQuery)
    {
      var dateNow = DateTime.Now;
      var trips = _tripRepository.GetUserTrips(userId)
                                 .Where(t => t.EndDate < dateNow);

      if (!string.IsNullOrEmpty(searchQuery))
        trips = trips.Where(t => t.DepartureCity.Contains(searchQuery) ||
                                 t.ArrivalCountry.Name.Contains(searchQuery) ||
                                 t.DepartureCountry.Name.Contains(searchQuery));

      return _mapper.Map<IEnumerable<TripDTO>>(trips.ToList());
    }
  }
}

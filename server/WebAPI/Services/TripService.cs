using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebAPI.DTO.Trip;
using AutoMapper;

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

    public IEnumerable<TripHistoryResponse> GetPreviousTrips(int userId, int? year, string searchQuery)
    {
      var culture = CultureInfo.CreateSpecificCulture("ru-RU");

      var date = DateTime.Now;
      var trips = _tripRepository.GetUserTrips(userId)
                                 .Where(t => t.EndDate < date);

      if (year.HasValue && year.Value > 0)
        trips = trips.Where(t => t.StartDate.Year.Equals(year.Value) ||
                                 t.EndDate.Year.Equals(year.Value));

      if (!string.IsNullOrEmpty(searchQuery))
        trips = trips.Where(t => t.DepartureCity.Contains(searchQuery) ||
                                 t.ArrivalCountry.Name.Contains(searchQuery) ||
                                 t.DepartureCountry.Name.Contains(searchQuery));

      return _mapper.Map<IEnumerable<TripHistoryResponse>>(trips.ToList());
    }
  }
}

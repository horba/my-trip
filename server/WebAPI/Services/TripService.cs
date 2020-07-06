using Entities;
using System;
using System.Collections.Generic;
using AutoMapper;
using WebAPI.DTO;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using WebAPI.DTO.Trip;

namespace WebAPI.Services
{
  public interface ITripService
  {
    IEnumerable<TripDTO> GetTripsHistory(int userId, string searchQuery);
    IEnumerable<TripDTO> GetUpcomingTrips(int userId);
    bool IsTripAllowed(int userId, int tripId);
    Task CreateTrip(int userId, TripRequestDTO trip);
  }

  public class TripService : ITripService
  {
    private readonly IMapper _mapper;
    private readonly ITripRepository _tripRepository;
    private readonly IGooglePlacePhotoService _photoService;


    public TripService(IMapper mapper, ITripRepository tripRepository, IGooglePlacePhotoService photoService)
    {
      _mapper = mapper;
      _tripRepository = tripRepository;
      _photoService = photoService;
    }

    public IEnumerable<TripDTO> GetTripsHistory(int userId, string searchQuery)
    {
      var dateNow = DateTime.Now;
      var trips = _tripRepository.GetUserTrips(userId)
                                 .Where(t => t.StartDate < dateNow);

      if (!string.IsNullOrEmpty(searchQuery))
        trips = trips.Where(t => t.DepartureCity.ToLower().Contains(searchQuery.ToLower()) ||
                                 t.ArrivalCountry.Name.ToLower().Contains(searchQuery.ToLower()) ||
                                 t.ArrivalCountry.NameRu.ToLower().Contains(searchQuery.ToLower()) ||
                                 t.ArrivalCountry.NameUa.ToLower().Contains(searchQuery.ToLower()));

      return _mapper.Map<IEnumerable<TripDTO>>(trips.OrderBy(t => t.StartDate).ToList());
    }

    public IEnumerable<TripDTO> GetUpcomingTrips(int userId)
    {
      var trips = _tripRepository.GetUserTrips(userId).Where(t => t.StartDate >= DateTime.Now);
      return _mapper.Map<IEnumerable<TripDTO>>(trips.OrderBy(t => t.StartDate).ToList());
    }

    public bool IsTripAllowed(int userId, int tripId)
    {
      return _tripRepository.GetUserTrips(userId).Any(tr => tr.Id == tripId);
    }

    public async Task CreateTrip(int userId, TripRequestDTO trip)
    {
      var tripDao = _mapper.Map<Trip>(trip);
      tripDao.UserId = userId;
      tripDao.ImageUrl = await _photoService.GetPlaceImage(tripDao.DepartureCity);
      _tripRepository.CreateTrip(tripDao);
    }
  }
}

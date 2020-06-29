using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using WebAPI.DTO;
using WebAPI.DTO.Waypoint;

namespace WebAPI.Services
{
  public interface IWaypointService
  {
    IEnumerable<WaypointDTO> GetWaypointDTOsOfTrip(int tripId);
    void UpdateCompletedState(int waypointId, bool state);
    void UpdateDetailsState(int waypointId, bool state);
    bool IsWaypointAllowed(int userId, int waypointId);
    Task<int> InsertWaypoint(WaypointRequestDTO waypointDTO);
    Task UpdateWaypoint(WaypointRequestDTO waypointDTO);
    void DeleteWaypoint(int waypointId);
  }

  public class WaypointService : IWaypointService
  {

    private readonly IWaypointRepository _waypointRepository;
    private readonly IWaypointFileService _waypointFileService;
    private readonly IGooglePlacePhotoService _photoService;
    private readonly IMapper _mapper;

    public WaypointService(IWaypointRepository waypointRepository, IMapper mapper, IGooglePlacePhotoService photoService, IWaypointFileService waypointFileService)
    {
      _waypointRepository = waypointRepository;
      _mapper = mapper;
      _photoService = photoService;
      _waypointFileService = waypointFileService;
    }

    private Waypoint GetWaypointById(int id)
    {
      return _waypointRepository.GetWaypoints().FirstOrDefault(waypoint => waypoint.Id == id);
    }

    public IEnumerable<WaypointDTO> GetWaypointDTOsOfTrip(int tripId)
    {
      return _mapper.Map<IEnumerable<WaypointDTO>>(_waypointRepository.GetWaypoints()
        .Where(waypoint => waypoint.TripId == tripId)
        .Include(waypoint => waypoint.Files)
        .OrderBy(waypoint => waypoint.Order));
    }

    public void UpdateCompletedState(int waypointId, bool state)
    {
      var waypoint = GetWaypointById(waypointId);

      if (waypoint != null)
      {
        waypoint.IsCompleted = state;
        _waypointRepository.UpdateWaypoint(waypoint);
      }
    }

    public void UpdateDetailsState(int waypointId, bool state)
    {
      var waypoint = GetWaypointById(waypointId);

      if (waypoint != null)
      {
        waypoint.IsDetails = state;
        _waypointRepository.UpdateWaypoint(waypoint);
      }
    }

    public bool IsWaypointAllowed(int userId, int waypointId)
    {
      return _waypointRepository
        .GetWaypoints()
        .Include(waypoint => waypoint.Trip)
        .FirstOrDefault(waypoint => waypoint.Id == waypointId)
        ?.Trip
        ?.UserId == userId;
    }

    public async Task<int> InsertWaypoint(WaypointRequestDTO waypointDTO)
    {
      var waypoint = _mapper.Map<Waypoint>(waypointDTO);
      var toReplace = _waypointRepository.GetWaypoints()
        .FirstOrDefault(waypoint => waypoint.TripId == waypointDTO.TripId && waypoint.City == waypointDTO.DepartureCity);

      var waypointImg = _photoService.GetPlaceImage(waypointDTO.DepartureCity);
      var nextwaypointImg = _photoService.GetPlaceImage(waypointDTO.ArrivalCity);

      var allImg = await Task.WhenAll(waypointImg, nextwaypointImg);
      waypoint.ImageUrl = allImg[0];

      if (toReplace == null)
      {
        int waypointCount = _waypointRepository.GetWaypoints().Count(waypoint => waypoint.TripId == waypointDTO.TripId);
        if (waypointCount > 0)
        {
          _waypointRepository.DeleteWaypoint(_waypointRepository
            .GetWaypoints()
            .Where(waypoint => waypoint.TripId == waypointDTO.TripId)
            .OrderByDescending(waypoint => waypoint.Order)
            .FirstOrDefault());
          waypointCount--;
        }

        waypoint.Order = waypointCount;
        _waypointRepository.AddWaypoint(waypoint);
        _waypointRepository.AddWaypoint(
          new Waypoint
          {
            City = waypointDTO.ArrivalCity,
            Order = waypointCount + 1,
            TripId = waypoint.TripId,
            ImageUrl = allImg[1]
          });
        return waypoint.Id;
      }

      waypoint.Order = toReplace.Order;
      waypoint.IsDetails = toReplace.IsDetails;
      waypoint.IsCompleted = toReplace.IsCompleted;
      toReplace.Order++;
      toReplace.IsDetails = toReplace.IsCompleted = false;
      toReplace.City = waypointDTO.ArrivalCity;
      toReplace.ImageUrl = allImg[1];

      var waypoints = _waypointRepository.GetWaypoints()
          .Where(w => w.TripId == waypointDTO.TripId && w.Order > waypoint.Order)
          .ToList();
      waypoints.ForEach(w => w.Order++);
      _waypointRepository.UpdateRange(waypoints);
      _waypointRepository.UpdateWaypoint(toReplace);

      _waypointRepository.AddWaypoint(waypoint);
      return waypoint.Id;
    }

    public async Task UpdateWaypoint(WaypointRequestDTO waypointDTO)
    {
      var waypoint = _mapper.Map<Waypoint>(waypointDTO);
      waypoint.Order = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.Id == waypoint.Id).Order;
      var nextwaypoint = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.TripId == waypoint.TripId && w.Order == waypoint.Order + 1);
      if (nextwaypoint != null)
      {
        var waypointImg = _photoService.GetPlaceImage(waypointDTO.DepartureCity);
        var nextwaypointImg = _photoService.GetPlaceImage(waypointDTO.ArrivalCity);

        var allImg = await Task.WhenAll(waypointImg, nextwaypointImg);

        nextwaypoint.City = waypointDTO.ArrivalCity;
        waypoint.ImageUrl = allImg[0];
        nextwaypoint.ImageUrl = allImg[1];

        var waypointfromDb = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.Id == waypoint.Id);
        waypoint.IsDetails = waypointfromDb.IsDetails;
        waypoint.IsCompleted = waypointfromDb.IsCompleted;

        _waypointRepository.UpdateWaypoint(waypoint);
        _waypointRepository.UpdateWaypoint(nextwaypoint);
      }
    }

    public void DeleteWaypoint(int waypointId)
    {
      var waypoint = GetWaypointById(waypointId);
      if (waypoint == null)
      {
        return;
      }

      var waypoints = _waypointRepository.GetWaypoints().Where(w => w.TripId == waypoint.TripId).ToList();

      if (waypoints.Count() == 2)
      {
        waypoints.ForEach(waypoint => _waypointFileService.DeleteAllFilesOfWaypoint(waypoint.Id));
        _waypointRepository.DeleteRange(waypoints);
        return;
      }

      _waypointFileService.DeleteAllFilesOfWaypoint(waypoint.Id);
      _waypointRepository.DeleteWaypoint(waypoint);
      var toMove = _waypointRepository.GetWaypoints()
        .Where(w => w.TripId == waypoint.TripId && w.Order > waypoint.Order)
        .ToList();

      toMove.ForEach(w => w.Order--);
      _waypointRepository.UpdateRange(toMove);
    }

  }
}

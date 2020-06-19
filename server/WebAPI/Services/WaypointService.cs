using System;
using System.Collections.Generic;
using System.Diagnostics;
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
  public class WaypointService
  {

    private readonly WaypointRepository _waypointRepository;
    private readonly IMapper _mapper;

    public WaypointService(WaypointRepository waypointRepository, IMapper mapper)
    {
      _waypointRepository = waypointRepository;
      _mapper = mapper;
    }

    private Waypoint GetWaypointById(int id)
    {
      return _waypointRepository.GetWaypoints().FirstOrDefault(wp => wp.Id == id);
    }

    public IEnumerable<WaypointDTO> GetWaypointDTOsOfTrip(int tripId)
    {
      return _mapper.Map<IEnumerable<WaypointDTO>>(_waypointRepository.GetWaypoints().Where(wp => wp.TripId == tripId).OrderBy(wp => wp.Order));
    }

    public void UpdateCompletedState(int wpId, bool state)
    {
      var wp = GetWaypointById(wpId);

      if (wp != null)
      {
        wp.IsCompleted = state;
        _waypointRepository.UpdateWaypoint(wp);
      }
    }

    public void UpdateDetailsState(int wpId, bool state)
    {
      var wp = GetWaypointById(wpId);

      if (wp != null)
      {
        wp.IsDetails = state;
        _waypointRepository.UpdateWaypoint(wp);
      }
    }

    public bool IsWaypointAllowed(int userId, int wpId)
    {
      return _waypointRepository
        .GetWaypoints()
        .Include(wp => wp.Trip)
        .FirstOrDefault(wp => wp.Id == wpId)
        ?.Trip
        ?.UserId == userId;
    }

    public void InsertWaypoint(WaypointRequestDTO wpDTO)
    {
      var wp = _mapper.Map<Waypoint>(wpDTO);
      var toReplace = _waypointRepository.GetWaypoints()
        .FirstOrDefault(wp => wp.TripId == wpDTO.TripId && wp.City == wpDTO.DepartureCity);

      if (toReplace == null)
      {
        int wpCount = _waypointRepository.GetWaypoints().Count(wp => wp.TripId == wpDTO.TripId);
        if (wpCount > 0)
        {
          _waypointRepository.DeleteWaypoint(_waypointRepository.GetWaypoints().Where(wp => wp.TripId == wpDTO.TripId).OrderByDescending(wp => wp.Order).FirstOrDefault());
          wpCount--;
        }

        wp.Order = wpCount;
        _waypointRepository.AddWaypoint(wp);
        _waypointRepository.AddWaypoint(new Waypoint { City = wpDTO.ArrivalCity, Order = wpCount + 1, TripId = wp.TripId });
        return;
      }

      wp.Order = toReplace.Order;
      toReplace.City = wpDTO.ArrivalCity;
      _waypointRepository.UpdateWaypoint(toReplace);

      var wps = _waypointRepository.GetWaypoints()
          .Where(w => w.TripId == wpDTO.TripId && w.Order >= toReplace.Order)
          .ToList();
      wps.ForEach(w => w.Order++);
      _waypointRepository.UpdateRange(wps);

      _waypointRepository.AddWaypoint(wp);

    }

    public void UpdateWaypoint(WaypointRequestDTO wpDTO)
    {
      var wp = _mapper.Map<Waypoint>(wpDTO);
      wp.Order = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.Id == wp.Id).Order;
      var nextWp = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.TripId == wp.TripId && w.Order == wp.Order + 1);
      if (nextWp != null)
      {
        nextWp.City = wpDTO.ArrivalCity;

        _waypointRepository.UpdateWaypoint(wp);
        _waypointRepository.UpdateWaypoint(nextWp);
      }
    }

    public void DeleteWaypoint(int wpId)
    {
      var wp = GetWaypointById(wpId);
      if (wp == null)
      {
        return;
      }

      var wps = _waypointRepository.GetWaypoints().Where(w => w.TripId == wp.TripId);

      if (wps.Count() == 2)
      {
        _waypointRepository.DeleteRange(wps);
        return;
      }

      _waypointRepository.DeleteWaypoint(wp);
      var toMove = _waypointRepository.GetWaypoints()
        .Where(w => w.TripId == wp.TripId && w.Order > wp.Order)
        .ToList();

      toMove.ForEach(w => w.Order--);
      _waypointRepository.UpdateRange(toMove);
    }

  }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.Models;
using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebAPI.DTO;
using WebAPI.DTO.Waypoint;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public class WaypointService
  {

    private readonly WaypointRepository _waypointRepository;
    private readonly WaypointFileService _waypointFileService;
    private readonly GooglePlacePhotoService _photoService;
    private readonly IMapper _mapper;

    public WaypointService(WaypointRepository waypointRepository, IMapper mapper, GooglePlacePhotoService photoService, WaypointFileService waypointFileService)
    {
      _waypointRepository = waypointRepository;
      _mapper = mapper;
      _photoService = photoService;
      _waypointFileService = waypointFileService;
    }

    private Waypoint GetWaypointById(int id)
    {
      return _waypointRepository.GetWaypoints().FirstOrDefault(wp => wp.Id == id);
    }

    public IEnumerable<WaypointDTO> GetWaypointDTOsOfTrip(int tripId)
    {
      return _mapper.Map<IEnumerable<WaypointDTO>>(_waypointRepository.GetWaypoints()
        .Where(wp => wp.TripId == tripId)
        .Include(wp => wp.Files)
        .OrderBy(wp => wp.Order));
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

    public async Task InsertWaypoint(WaypointRequestDTO wpDTO)
    {
      var wp = _mapper.Map<Waypoint>(wpDTO);
      var toReplace = _waypointRepository.GetWaypoints()
        .FirstOrDefault(wp => wp.TripId == wpDTO.TripId && wp.City == wpDTO.DepartureCity);

      var wpImg = _photoService.GetPlaceImage(wpDTO.DepartureCity);
      var nextWpImg = _photoService.GetPlaceImage(wpDTO.ArrivalCity);

      var allImg = await Task.WhenAll(wpImg, nextWpImg);
      wp.ImageUrl = allImg[0];

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
        _waypointRepository.AddWaypoint(new Waypoint { City = wpDTO.ArrivalCity, Order = wpCount + 1, TripId = wp.TripId, ImageUrl = allImg[1] });
        return;
      }

      wp.Order = toReplace.Order;
      wp.IsDetails = toReplace.IsDetails;
      wp.IsCompleted = toReplace.IsCompleted;
      toReplace.Order++;
      toReplace.IsDetails = toReplace.IsCompleted = false;
      toReplace.City = wpDTO.ArrivalCity;
      toReplace.ImageUrl = allImg[1];

      var wps = _waypointRepository.GetWaypoints()
          .Where(w => w.TripId == wpDTO.TripId && w.Order > wp.Order)
          .ToList();
      wps.ForEach(w => w.Order++);
      _waypointRepository.UpdateRange(wps);
      _waypointRepository.UpdateWaypoint(toReplace);

      _waypointRepository.AddWaypoint(wp);

    }

    public async Task UpdateWaypoint(WaypointRequestDTO wpDTO)
    {
      var wp = _mapper.Map<Waypoint>(wpDTO);
      wp.Order = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.Id == wp.Id).Order;
      var nextWp = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.TripId == wp.TripId && w.Order == wp.Order + 1);
      if (nextWp != null)
      {
        var wpImg = _photoService.GetPlaceImage(wpDTO.DepartureCity);
        var nextWpImg = _photoService.GetPlaceImage(wpDTO.ArrivalCity);

        var allImg = await Task.WhenAll(wpImg, nextWpImg);

        nextWp.City = wpDTO.ArrivalCity;
        wp.ImageUrl = allImg[0];
        nextWp.ImageUrl = allImg[1];

        var wpfromDb = _waypointRepository.GetWaypoints().FirstOrDefault(w => w.Id == wp.Id);
        wp.IsDetails = wpfromDb.IsDetails;
        wp.IsCompleted = wpfromDb.IsCompleted;

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

      var wps = _waypointRepository.GetWaypoints().Where(w => w.TripId == wp.TripId).ToList();

      if (wps.Count() == 2)
      {
        wps.ForEach(wp => _waypointFileService.DeleteAllFilesOfWaypoint(wp.Id));
        _waypointRepository.DeleteRange(wps);
        return;
      }

      _waypointFileService.DeleteAllFilesOfWaypoint(wp.Id);
      _waypointRepository.DeleteWaypoint(wp);
      var toMove = _waypointRepository.GetWaypoints()
        .Where(w => w.TripId == wp.TripId && w.Order > wp.Order)
        .ToList();

      toMove.ForEach(w => w.Order--);
      _waypointRepository.UpdateRange(toMove);
    }

  }
}

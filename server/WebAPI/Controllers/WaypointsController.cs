using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.DTO.Waypoint;
using WebAPI.Extension;
using WebAPI.Services;
using WebAPI.Services.Waypoints;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class WaypointsController : ControllerBase
  {

    private readonly WaypointService _waypointService;
    private readonly TripService _tripService;

    public WaypointsController(WaypointService waypointService, TripService tripService)
    {
      _tripService = tripService;
      _waypointService = waypointService;
    }

    [HttpGet]
    [Route("bytrip/{id}")]
    public IActionResult GetWaypoints(int id)
    {
      return Ok(_waypointService.GetWaypointDTOsOfTrip(id));
    }

    [HttpPut]
    [Route("set-completed-state")]
    public IActionResult SetCompletedState(CheckboxDTO waypoint)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), waypoint.Id))
      {
        return Forbid();
      }

      _waypointService.UpdateCompletedState(waypoint.Id, waypoint.State);
      return Ok();
    }

    [HttpPut]
    [Route("set-details-state")]
    public IActionResult SetDetailsState(CheckboxDTO waypoint)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), waypoint.Id))
      {
        return Forbid();
      }

      _waypointService.UpdateDetailsState(waypoint.Id, waypoint.State);
      return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWaypoint(WaypointRequestDTO wp)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), wp.NewId))
      {
        return Forbid();
      }

      await _waypointService.UpdateWaypoint(wp);
      return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteWaypoint(int id)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), id))
      {
        return Forbid();
      }

      _waypointService.DeleteWaypoint(id);
      return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateWaypoint(WaypointRequestDTO wp)
    {
      if (!_tripService.IsTripAllowed(HttpContext.GetUserIdFromClaim(), wp.TripId))
      {
        return Forbid();
      }

      await _waypointService.InsertWaypoint(wp);
      return Ok();
    }

  }
}
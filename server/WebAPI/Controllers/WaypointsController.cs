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

    private WaypointService _waypointService;
    private WaypointRepository _waypointRepository;

    public WaypointsController(WaypointService waypointService, WaypointRepository waypointRepository)
    {
      _waypointService = waypointService;
      _waypointRepository = waypointRepository;
    }

    [HttpGet]
    [Route("bytrip/{id}")]
    public IActionResult GetWaypoints(int id)
    {
      return Ok(_waypointService.GetWaypoints(id));
    }

    [HttpPut]
    [Route("set-completed-state")]
    public IActionResult SetCompletedState(WaypointCompletedDTO waypoint)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), waypoint.Id))
      {
        return Forbid();
      }

      _waypointService.UpdateCompletedState(waypoint.Id, waypoint.State);
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

      _waypointRepository.DeleteWaypoint(new Waypoint { Id = id });
      return Ok();
    }

  }
}
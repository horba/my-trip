﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.DTO.Trip;
using WebAPI.Extension;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TripsController : ControllerBase
  {
    private readonly TripService _tripService;

    public TripsController(TripService tripService)
    {
      _tripService = tripService;
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateTrip(TripRequestDTO trip)
    {
      await _tripService.CreateTrip(HttpContext.GetUserIdFromClaim(), trip);
      return Ok();
    }

    [Authorize]
    [Route("history")]
    [ProducesResponseType(typeof(IEnumerable<TripDTO>), StatusCodes.Status200OK)]
    public IActionResult GetTripsHistory(string searchQuery)
    {
      var trips = _tripService.GetTripsHistory(HttpContext.GetUserIdFromClaim(), searchQuery);
      return Ok(trips);
    }

    [HttpGet]
    [Authorize]
    [Route("upcoming")]
    [ProducesResponseType(typeof(IEnumerable<TripDTO>), StatusCodes.Status200OK)]
    public IActionResult GetUpcomingTrips()
    {
      var trips = _tripService.GetUpcomingTrips(HttpContext.GetUserIdFromClaim());
      return Ok(trips);
    }
  }
}

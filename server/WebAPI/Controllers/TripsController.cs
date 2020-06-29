using Microsoft.AspNetCore.Authorization;
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
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class TripsController : ControllerBase
  {
    private readonly ITripService _tripService;

    public TripsController(ITripService tripService)
    {
      _tripService = tripService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrip(TripRequestDTO trip)
    {
      await _tripService.CreateTrip(HttpContext.GetUserIdFromClaim(), trip);
      return Ok();
    }

    [Route("history")]
    [ProducesResponseType(typeof(IEnumerable<TripDTO>), StatusCodes.Status200OK)]
    public IActionResult GetTripsHistory(string searchQuery)
    {
      var trips = _tripService.GetTripsHistory(HttpContext.GetUserIdFromClaim(), searchQuery);
      return Ok(trips);
    }

    [HttpGet]
    [Route("upcoming")]
    [ProducesResponseType(typeof(IEnumerable<TripDTO>), StatusCodes.Status200OK)]
    public IActionResult GetUpcomingTrips()
    {
      var trips = _tripService.GetUpcomingTrips(HttpContext.GetUserIdFromClaim());
      return Ok(trips);
    }
  }
}

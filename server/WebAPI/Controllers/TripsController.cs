using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
    [Route("previous")]
    [ProducesResponseType(typeof(IEnumerable<TripHistoryResponse>), StatusCodes.Status200OK)]
    public IActionResult GetPreviousTrips(int? year, string searchQuery)
    {
      var trips = _tripService.GetPreviousTrips(HttpContext.GetUserIdFromClaim(), year, searchQuery);
      return Ok(trips);
    }
  }
}
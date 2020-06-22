using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.DTO;
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
    [Route("history")]
    [ProducesResponseType(typeof(IEnumerable<TripDTO>), StatusCodes.Status200OK)]
    [HttpGet]
    public IActionResult GetTripsHistory(string searchQuery)
    {
      var trips = _tripService.GetTripsHistory(HttpContext.GetUserIdFromClaim(), searchQuery);
      return Ok(trips);
    }
  }
}

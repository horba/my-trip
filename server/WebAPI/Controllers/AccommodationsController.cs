using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Extension;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class AccommodationsController : ControllerBase
  {
    private readonly AccommodationService _accommodationService;

    public AccommodationsController(AccommodationService accommodationService)
    {
      _accommodationService = accommodationService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<AccommodationDTO>), StatusCodes.Status200OK)]
    public IActionResult GetAccommodations()
    {
      return Ok(_accommodationService.GetAccommodations(HttpContext.GetUserIdFromClaim()));
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(AccommodationDTO), StatusCodes.Status200OK)]
    public IActionResult GetAccommodation([FromRoute] int id)
    {
      var accommodation = _accommodationService.GetAccommodation(id);

      if (!accommodation.UserId.Equals(HttpContext.GetUserIdFromClaim()))
        return Forbid();

      return Ok(accommodation);
    }

    [HttpPost]
    [ProducesResponseType(typeof(AccommodationDTO), StatusCodes.Status200OK)]
    public IActionResult AddAccommodation(AccommodationDTO model)
    {
      if (model.DepartureDateTime < model.ArrivalDateTime)
      {
        ModelState.AddModelError(nameof(model.DepartureDateTime), $"{nameof(model.DepartureDateTime)} must be greater then {nameof(model.ArrivalDateTime)}.");
        return BadRequest(ModelState);
      }

      model.UserId = HttpContext.GetUserIdFromClaim();
      _accommodationService.CreateOrUpdateAccommodation(model);

      return Ok();
    }
  }
}

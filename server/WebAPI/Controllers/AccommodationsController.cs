using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.DTO.Accommodation;
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
    public IActionResult GetAccommodations(
      [FromQuery] PaginationRequestQueryDTO paginationRequestQuery, 
      [FromQuery] AccommodationSortingQueryDTO accommodationSortingQuery, 
      [FromQuery] AccommodationFilterQueryDTO accommodationFilterQuery )
    {
      return Ok(_accommodationService.GetAccommodations(HttpContext.GetUserIdFromClaim(), paginationRequestQuery, accommodationSortingQuery, accommodationFilterQuery));
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

    [HttpGet]
    [Route("max-price")]
    public IActionResult GetMaxPrice()
    {
      return Ok(new {price = _accommodationService.GetMaxPrice(HttpContext.GetUserIdFromClaim())});
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

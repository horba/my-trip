using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
  public class EntertainmentController : ControllerBase
  {

    private readonly IEntertainmentService _entertainmentService;

    public EntertainmentController(IEntertainmentService entertainmentService)
    {
      _entertainmentService = entertainmentService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<EntertainmentDTO>), StatusCodes.Status200OK)]
    public IActionResult GetEntertainments()
    {
      return Ok(_entertainmentService.GetEntertainments(HttpContext.GetUserIdFromClaim()));
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(EntertainmentDTO), StatusCodes.Status200OK)]
    public IActionResult GetEntertainment([FromRoute] int id)
    {
      var entertainment = _entertainmentService.GetEntertainment(id);

      if (!entertainment.UserId.Equals(HttpContext.GetUserIdFromClaim()))
        return Forbid();

      return Ok(entertainment);
    }

    [HttpPost]
    public IActionResult AddEntertainment(EntertainmentDTO model)
    {
      model.UserId = HttpContext.GetUserIdFromClaim();
      _entertainmentService.CreateOrUpdateEntertainment(model);

      return Ok();
    }
    
    [HttpDelete]
    [Route("{id}")]
    public IActionResult RemoveFilePath([FromRoute] int id) {
      _entertainmentService.RemoveFilePath(id);

      return Ok();
    }

  }
}

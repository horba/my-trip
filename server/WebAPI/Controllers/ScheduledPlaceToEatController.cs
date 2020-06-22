using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Extension;
using WebAPI.Services;
using WebAPI.Services.Assets;

namespace WebAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ScheduledPlaceToEatController : ControllerBase
  {
    private readonly ScheduledPlaceToEatService _scheduledPlaceToEatService;

    public ScheduledPlaceToEatController(ScheduledPlaceToEatService scheduledPlaceToEatService)
    {
      _scheduledPlaceToEatService = scheduledPlaceToEatService;
    }

    // GET: api/ScheduledPlaceToEat
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ScheduledPlaceToEatDTO>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()));
    }

    // POST: api/ScheduledPlaceToEat/Create
    [HttpPost("Create")]
    public void Create([FromBody] ScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
        if(ScheduledPlaceToEatDTO.Attachments.Count <= Consts.MaxEatingFileCount)
        {
          foreach(var file in ScheduledPlaceToEatDTO.Attachments)
          {
            if(file.Length >= Consts.MaxEatingFileSize)
            {
              return;
            }
          }
          ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
          _scheduledPlaceToEatService.CreateNewEating(ScheduledPlaceToEatDTO);
        }
    }

    // POST: api/ScheduledPlaceToEat/UpdateScheduledPlaceToEat
    [HttpPost("Update")]
    public void Update([FromBody] ScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
      if(ScheduledPlaceToEatDTO.Attachments.Count <= Consts.MaxEatingFileCount)
      {
        foreach(var file in ScheduledPlaceToEatDTO.Attachments)
        {
          if(file.Length >= Consts.MaxEatingFileSize)
          {
            return;
          }
        }
        ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
        _scheduledPlaceToEatService.UpdateEating(ScheduledPlaceToEatDTO);
      }
    }

    // DELETE: api/ScheduledPlaceToEat/DeleteScheduledPlaceToEat
    [Authorize]
    [HttpPost("Delete")]
    public void Delete([FromBody] ScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
      if(ScheduledPlaceToEatDTO.Attachments.Count <= Consts.MaxEatingFileCount)
      {
        foreach(var file in ScheduledPlaceToEatDTO.Attachments)
        {
          if(file.Length >= Consts.MaxEatingFileSize)
          {
            return;
          }
        }
        ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
        _scheduledPlaceToEatService.DeleteScheduledPlaceToEat(ScheduledPlaceToEatDTO);
      }
    }
  }
}

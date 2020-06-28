using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Extension;
using WebAPI.Interfaces;
using WebAPI.Services.Assets;

namespace WebAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ScheduledPlaceToEatController : ControllerBase
  {
    private readonly IScheduledPlaceToEatService _scheduledPlaceToEatService;
    private readonly IAttachmentFileEatingService _attachmentFileEatingService;

    public ScheduledPlaceToEatController(
      IScheduledPlaceToEatService scheduledPlaceToEatService,
      IAttachmentFileEatingService attachmentFileEatingService)
    {
      _scheduledPlaceToEatService = scheduledPlaceToEatService;
      _attachmentFileEatingService = attachmentFileEatingService;
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(InputScheduledPlaceToEatForCreateDTO), StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] int id)
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()).Where(r => r.Id.Equals(id)).FirstOrDefault());
    }

    // GET: api/ScheduledPlaceToEat
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<InputScheduledPlaceToEatForCreateDTO>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()));
    }

    [HttpPost("UploadEatingMultiFile/{id}")]
    [Consumes("multipart/form-data")]
    public IActionResult UploadEatingMultiFile([FromForm] IFormFileCollection files, int id)
    {
      if(files.Count <= Consts.MaxEatingFileCount && files.Count > 0)
      {
        foreach(var file in files)
        {
          if(!Consts.AllowedImageContentTypes.Contains(file.ContentType, StringComparer.OrdinalIgnoreCase) && !Consts.AllowedTextContentTypes.Contains(file.ContentType, StringComparer.OrdinalIgnoreCase))
          {
            return BadRequest("notAllowedContentType");
          }

          if(file.Length > Consts.MaxEatingFileSize)
          {
            return BadRequest("fileIsToBig");
          }

          _attachmentFileEatingService.Create(file, id, HttpContext.GetUserIdFromClaim());
        }
      }
      return Ok();
    }

    [HttpPost("DeleteEatingFile")]
    public IActionResult DeleteEatingFiles(int fileId)
    {
      _attachmentFileEatingService.Delete(fileId, HttpContext.GetUserIdFromClaim());
      return Ok();
    }

    // POST: api/ScheduledPlaceToEat/Create
    [HttpPost("Create")]
    public int Create([FromBody] InputScheduledPlaceToEatForCreateDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return _scheduledPlaceToEatService.CreateNewEating(ScheduledPlaceToEatDTO);
    }

    // POST: api/ScheduledPlaceToEat/Update
    [HttpPost("Update")]
    public IActionResult Update([FromBody] InputScheduledPlaceToEatForUpdateOrDeleteDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return _scheduledPlaceToEatService.UpdateScheduledPlaceToEat(ScheduledPlaceToEatDTO) ? Ok() : (IActionResult)BadRequest();
    }

    // DELETE: api/ScheduledPlaceToEat/Delete
    [HttpPost("Delete")]
    public IActionResult Delete([FromBody] InputScheduledPlaceToEatForUpdateOrDeleteDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return _scheduledPlaceToEatService.DeleteScheduledPlaceToEat(ScheduledPlaceToEatDTO) ? Ok() : (IActionResult)BadRequest();
    }

    // DELETE: api/ScheduledPlaceToEat/DeleteById/id
    [HttpPost("DeleteById/{id}")]
    public IActionResult Delete( int id)
    {
      var scheduledPlaceToEatDTO = _scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()).Where(r => r.Id.Equals(id)).FirstOrDefault();
      return Delete(new InputScheduledPlaceToEatForUpdateOrDeleteDTO {
      Id = scheduledPlaceToEatDTO.Id,
      DateTime = scheduledPlaceToEatDTO.DateTime,
      GooglePlaceId = scheduledPlaceToEatDTO.GooglePlaceId,
      Lat = scheduledPlaceToEatDTO.Lat,
      Link = scheduledPlaceToEatDTO.Link,
      Lng = scheduledPlaceToEatDTO.Lng,
      NamePlace = scheduledPlaceToEatDTO.NamePlace,
      Notes = scheduledPlaceToEatDTO.Notes
      });
    }
  }
}

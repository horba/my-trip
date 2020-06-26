using System;
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
    private readonly AttachmentFileEatingService _attachmentFileEatingService;

    public ScheduledPlaceToEatController(ScheduledPlaceToEatService scheduledPlaceToEatService, AttachmentFileEatingService attachmentFileEatingService)
    {
      _scheduledPlaceToEatService = scheduledPlaceToEatService;
      _attachmentFileEatingService = attachmentFileEatingService;
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(InputScheduledPlaceToEatDTO), StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] int id)
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()).Where(r => r.Id.Equals(id)).FirstOrDefault());
    }

    // GET: api/ScheduledPlaceToEat
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<InputScheduledPlaceToEatDTO>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()));
    }

    [HttpPost("UploadEatingMultiFile")]
    public IActionResult UploadEatingMultiFile(IFormFileCollection files, int eatingId)
    {
      if(files.Count <= Consts.MaxEatingFileCount && files.Count > 0)
      {
        List<AttachmentFileEatingDTO> fileNames = new List<AttachmentFileEatingDTO>();
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

          _attachmentFileEatingService.Create(file, eatingId, HttpContext.GetUserIdFromClaim());
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
    public int Create([FromBody] InputScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return _scheduledPlaceToEatService.CreateNewEating(ScheduledPlaceToEatDTO);
    }

    // POST: api/ScheduledPlaceToEat/Update
    [HttpPost("Update")]
    public void Update([FromBody] InputScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      _scheduledPlaceToEatService.UpdateEating(ScheduledPlaceToEatDTO);
    }

    // DELETE: api/ScheduledPlaceToEat/Delete
    [Authorize]
    [HttpPost("Delete")]
    public void Delete([FromBody] InputScheduledPlaceToEatDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      _attachmentFileEatingService.DeleteFilesEating(ScheduledPlaceToEatDTO.Id, ScheduledPlaceToEatDTO.UserId);
      _scheduledPlaceToEatService.DeleteScheduledPlaceToEat(ScheduledPlaceToEatDTO);
    }
  }
}

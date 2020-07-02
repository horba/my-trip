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
using AutoMapper;
using WebAPI.Validators;

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
      return Ok(_scheduledPlaceToEatService.GetEatingById(id));
    }

    // GET: api/ScheduledPlaceToEat
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<OutputScheduledPlaceToEatDTO>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
      return Ok(_scheduledPlaceToEatService.GetEatingByUserId(HttpContext.GetUserIdFromClaim()));
    }

    [HttpPost("UploadEatingMultiFile/{id}")]
    [Consumes("multipart/form-data")]
    // [ValidFileType(Consts.AllowedImageContentTypes)]
    public IActionResult UploadEatingMultiFile([FromForm, ValidFilesCount(Consts.MaxEatingFileCount)] IEnumerable<IFormFile> files, int id)
    {
        foreach(var file in files)
        {
          if(!Consts.AllowedImageContentTypes.Contains(file.ContentType, StringComparer.OrdinalIgnoreCase) && !Consts.AllowedTextContentTypes.Contains(file.ContentType, StringComparer.OrdinalIgnoreCase))
          {
            return BadRequest("notAllowedContentType");
          }
            _attachmentFileEatingService.Create(file, id, HttpContext.GetUserIdFromClaim());
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
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Create([FromBody] InputScheduledPlaceToEatForCreateDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return Ok(_scheduledPlaceToEatService.CreateNewEating(ScheduledPlaceToEatDTO));
    }

    // POST: api/ScheduledPlaceToEat/Update
    [HttpPost("Update")]
    public IActionResult Update([FromBody] InputScheduledPlaceToEatForUpdateDTO ScheduledPlaceToEatDTO)
    {
      ScheduledPlaceToEatDTO.UserId = HttpContext.GetUserIdFromClaim();
      return _scheduledPlaceToEatService.UpdateScheduledPlaceToEat(ScheduledPlaceToEatDTO) ? Ok() : (IActionResult)BadRequest();
    }

    // DELETE: api/ScheduledPlaceToEat/DeleteById/id
    [HttpPost("DeleteById/{id}")]
    public IActionResult Delete(int id)
    {
      var userId = HttpContext.GetUserIdFromClaim();
      _attachmentFileEatingService.DeleteFilesEating(id, userId);
      return _scheduledPlaceToEatService.DeleteScheduledPlaceToEat(id, userId) ? Ok() : (IActionResult)BadRequest();
    }
  }
}

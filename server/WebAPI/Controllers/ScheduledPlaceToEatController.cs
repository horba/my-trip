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
using System.ComponentModel.DataAnnotations;

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
    public IActionResult UploadEatingMultiFile([FromForm, ValidFilesCount(Consts.MaxEatingFileCount)] IEnumerable<IFormFile> files, int id)
    {
      var results = new List<ValidationResult>();
      var validationAttributes = new List<ValidationAttribute>
      {
        new ValidFileType(new string[] { "image/png", ".jpeg", ".jpg", ".bmp", ".txt", ".doc", ".docx", ".pdf" })
      };
      var notValidFiles = new List<string>();
      foreach(var file in files)
      {
        var context = new System.ComponentModel.DataAnnotations.ValidationContext(file);
        if(Validator.TryValidateValue(file, context, results, validationAttributes))
        {
          _attachmentFileEatingService.Create(file, id, HttpContext.GetUserIdFromClaim());
        }
        else
        {
          notValidFiles.Add(file.FileName);
        }
      }
      return Ok(notValidFiles);
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

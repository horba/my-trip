using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Extension;
using WebAPI.Services;
using WebAPI.Services.Assets;
using WebAPI.Validators;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class AssetsController : ControllerBase
  {
    private readonly AssetsService _assetsService;
    private readonly UserService _userService;

    public AssetsController(AssetsService filesService, UserService userService)
    {
      _assetsService = filesService;
      _userService = userService;
    }

    [HttpPost]
    [Route("{assetType}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadFile([FromForm, Required] IFormFile file, [FromRoute] AssetType assetType)
    {
      var results = new List<ValidationResult>();
      var validationAttributes = new List<ValidationAttribute>
      {
        new ValidFileType(new string[] { "png", ".jpeg", ".jpg", ".bmp"}),
        new ValidFileSize(Consts.MaxImageFileSize)
      };
      var context = new ValidationContext(file);

      if(Validator.TryValidateValue(file, context, results, validationAttributes))
      {

        switch(assetType)
        {
          case AssetType.UserAvatar:
          {
            var fileName = await _assetsService.SaveFileAsync(file, assetType);
            _userService.UpdateUserAvatar(HttpContext.GetUserIdFromClaim(), fileName);
            break;
          }
          default:
            break;
        }
      }
      return Ok();
    }

    [HttpDelete]
    [Route("{assetType}/{fileName}")]
    public IActionResult DeleteFile([FromRoute] AssetType assetType, [FromRoute] string fileName)
    {
      if(string.IsNullOrEmpty(fileName))
        return BadRequest("File name is required");

      _assetsService.DeleteFile(fileName, assetType);

      switch(assetType)
      {
        case AssetType.UserAvatar:
        {
          _userService.UpdateUserAvatar(HttpContext.GetUserIdFromClaim(), fileName);
          break;
        }
        default:
          break;
      }

      return Ok();
    }
  }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Services.Assets;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AssetsController : ControllerBase
  {
    private readonly AssetsService _filesService;

    public AssetsController(AssetsService filesService)
    {
      _filesService = filesService;
    }

    [HttpPut]
    [Route("{assetType}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadFile([FromForm] IFormFile file, [FromRoute] AssetType assetType)
    {
      if (file == null || file.Length < 0)
        return BadRequest("fileIsEmpty");

      if (!Consts.AllowedImageContentTypes.Contains(file.ContentType, StringComparer.OrdinalIgnoreCase))
        return BadRequest("notAllowedContentType");

      if (file.Length > Consts.MaxImageFileSize)
        return BadRequest("fileIsToBig");

      var fileName = await _filesService.SaveFileAsync(file, assetType);

      return Ok(fileName);
    }

    [HttpDelete]
    [Route("{assetType}")]
    public IActionResult DeleteFile(string fileName, [FromRoute] AssetType assetType)
    {
      _filesService.DeleteFile(fileName, assetType);
      return Ok();
    }
  }
}
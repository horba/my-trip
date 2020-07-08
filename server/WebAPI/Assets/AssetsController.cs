using Microsoft.AspNetCore.Authorization;
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
  [Authorize]
  public class AssetsController : ControllerBase
  {
    private readonly AssetsService _filesService;

    public AssetsController(AssetsService filesService)
    {
      _filesService = filesService;
    }

    [HttpPost]
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
    [Route("{assetType}/{fileName}")]
    public IActionResult DeleteFile([FromRoute] AssetType assetType, [FromRoute] string fileName)
    {
      if (string.IsNullOrEmpty(fileName))
        return BadRequest("File name is required");

      _filesService.DeleteFile(fileName, assetType);
      return Ok();
    }
  }
}

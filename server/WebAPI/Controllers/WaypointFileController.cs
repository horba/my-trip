using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Extension;
using WebAPI.Services;
using WebAPI.Services.Assets;

namespace WebAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class WaypointFileController : ControllerBase
  {

    private readonly IWaypointFileService _waypointFileService;
    private readonly IWaypointService _waypointService;

    public WaypointFileController(IWaypointFileService waypointFileFileService, IWaypointService waypointService)
    {
      _waypointFileService = waypointFileFileService;
      _waypointService = waypointService;
    }

    [HttpPost]
    [Route("{id}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadFile(int id, [FromForm] IFormFile file)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), id))
        return Forbid();

      if (file == null || file.Length < 0)
        return BadRequest("fileIsEmpty");

      if (file.Length > Consts.MaxWaypointFileSize)
        return BadRequest("fileIsToBig");

      if (!_waypointFileService.HasFreeSpace(id))
        return BadRequest("NoSpaceAvailable");

      return Ok(await _waypointFileService.AddFile(id, file));
    }

    [HttpPost]
    [Route("multiple/{id}")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> UploadFiles(int id, [FromForm] IFormFileCollection files)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), id))
        return Forbid();

      foreach (var file in files)
      {
        if (file == null || file.Length < 0)
          return BadRequest("fileIsEmpty");

        if (file.Length > Consts.MaxWaypointFileSize)
          return BadRequest("fileIsToBig");

        if (!_waypointFileService.HasFreeSpace(id))
          return BadRequest("NoSpaceAvailable");

        await _waypointFileService.AddFile(id, file);
      }

      return Ok();
    }

    [HttpDelete]
    [Route("{id}/{actualName}")]
    public IActionResult DeleteFile(string actualName, int id)
    {
      if (!_waypointService.IsWaypointAllowed(HttpContext.GetUserIdFromClaim(), id))
        return Forbid();

      _waypointFileService.DeleteFile(actualName);
      return Ok();
    }

  }
}

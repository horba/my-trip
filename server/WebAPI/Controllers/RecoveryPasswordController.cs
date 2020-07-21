using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RecoveryPasswordController : ControllerBase
  {
    private readonly RecoveryPasswordService recoveryPasswordService;
    public RecoveryPasswordController(RecoveryPasswordService recoveryPasswordService)
    {
      this.recoveryPasswordService = recoveryPasswordService;
    }

    [HttpPost("UpdatePassword")]
    public async Task<IActionResult> UpdatePasswordAsync(UpdatePasswordModel updatePasswordModel)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      await recoveryPasswordService.UpdatePasswordAsync(updatePasswordModel);
      return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> ResetPasswordAsync(RecoveryPasswordModel recoveryPasswordModel)
    {
      try
      {
        await recoveryPasswordService.SendEmailAsync(recoveryPasswordModel);
        return Ok();
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}

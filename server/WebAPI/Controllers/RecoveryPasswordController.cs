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

    [HttpPost("ResetPassword")]
    public IActionResult ResetPassword(RecoveryPasswordModel recoveryPasswordModel)
    {
      if(recoveryPasswordModel.Email != "" &&
        recoveryPasswordModel.Password != "" &&
        recoveryPasswordModel.Token != "")
      {
        return Ok(recoveryPasswordService.UpdatePassword(recoveryPasswordModel));
      }
      else
      {
        return BadRequest(false);
      }
    }

    [HttpPost]
    public async Task<IActionResult> ResetPasswordAsync(RecoveryPasswordModel recoveryPasswordModel)
    {
      if(recoveryPasswordModel.Email != "")
      {
        return Ok(await recoveryPasswordService.SendEmailAsync(recoveryPasswordModel));
      }
      else
      {
        return BadRequest($"user is not valid. user = {recoveryPasswordModel.Email}");
      }
    }
  }
}

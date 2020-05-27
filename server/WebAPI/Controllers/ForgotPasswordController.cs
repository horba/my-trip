using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ForgotPasswordController : ControllerBase
  {
    private readonly ResetPasswordService resetPasswordService;
    public ForgotPasswordController(ResetPasswordService resetPasswordService)
    {
      this.resetPasswordService = resetPasswordService;
    }

    [HttpPost("ResetPassword")]
    public IActionResult ResetPassword(RecoveryPasswordModel resetPasswordModel)
    {
      if(resetPasswordModel.Email != "" &&
        resetPasswordModel.Password != "" &&
        resetPasswordModel.Token != "")
      {
        return Ok(resetPasswordService.UpdatePassword(resetPasswordModel));
      }
      else
      {
        return BadRequest(false);
      }
    }

    [HttpPost]
    public async Task<IActionResult> ResetPasswordAsync(RecoveryPasswordModel resetPasswordModel)
    {
      if(resetPasswordModel.Email != "")
      {
        return Ok(await resetPasswordService.SendEmailAsync(resetPasswordModel));
      }
      else
      {
        return BadRequest($"user is not valid. user = {resetPasswordModel.Email}");
      }
    }
  }
}

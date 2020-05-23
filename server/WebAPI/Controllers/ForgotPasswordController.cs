using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IEmailSender emailSender;
        private readonly UserService userService;
        private readonly AuthService authService;

        public ForgotPasswordController( UserService userService, IEmailSender emailSender, AuthService authService)
        {
            this.userService = userService;
            this.emailSender = emailSender;
            this.authService = authService;
        }

        [HttpPost("ResetPassword")]
        public IActionResult ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if(resetPasswordModel.Email != "" && resetPasswordModel.Password != "")
            {
                var result = userService.UpdateUserPassword(resetPasswordModel.Email, resetPasswordModel.Password);
                return Ok(result);
            }
            return Ok(false);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordModel resetPasswordModel)
        {
            var user = userService.GetUser(resetPasswordModel.Email);
            if(user != null)
			{
				var token = authService.MakeToken(user, false);
				var message = new Message(new string[] { user.Email },
					"Reset password token", $"<a href='localhost:8080/recovery-password/{token}'>Recovery password</a>",
					null);
				await emailSender.SendEmailAsync(message);
				return Ok();
			}
			return BadRequest($"user is not valid. user = {user}");
        }
    }
}
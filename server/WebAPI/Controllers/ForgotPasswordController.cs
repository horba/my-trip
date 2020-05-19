using System.Threading.Tasks;
using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IEmailSender emailSender;
        private IMapper mapper;
        private UserService userService;

        public ForgotPasswordController(IMapper mapper, UserService userManager, IEmailSender emailSender)
        {
            this.mapper = mapper;
            this.userService = userManager;
            this.emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordModel { Token = token, Email = email };
            return Ok(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if(!ModelState.IsValid)
                return BadRequest(resetPasswordModel);

            var user = userService.GetUser(resetPasswordModel.Email);
            if(user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));

            var resetPassResult = await userService.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if(!resetPassResult.Succeeded)
            {
                foreach(var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View();
            }

            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            if(!ModelState.IsValid)
                return BadRequest(forgotPasswordModel);

            var user = userService.GetUser(forgotPasswordModel.Email);
            if(user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            var token = await userService.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), nameof(ForgotPasswordController), new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "codemazetest@gmail.com" }, "Reset password token", callback, null);
            await emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }
    }
}
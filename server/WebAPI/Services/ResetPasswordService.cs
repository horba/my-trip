using System;
using WebAPI.DTO;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
  public class ResetPasswordService
  {
    private readonly IEmailSender emailSender;
    private readonly UserService userService;
    private readonly AuthService authService;
    private readonly FrontConfiguration frontConfiguration;
    public ResetPasswordService(UserService userService,
        IEmailSender emailSender, AuthService authService, FrontConfiguration frontConfiguration)
    {
      this.userService = userService;
      this.emailSender = emailSender;
      this.authService = authService;
      this.frontConfiguration = frontConfiguration;
    }
    public bool UpdatePass(ResetPasswordModel resetPasswordModel)
    {
      try
      {
        var result = userService.UpdateUserPassword(resetPasswordModel.Email, resetPasswordModel.Password);
        if(result)
        {
          var message = new Message(new string[] { resetPasswordModel.Email },
              "Reset password token", "Your password has been changed successfully. " +
              $"Please check our <a href = '{frontConfiguration.AddressFront}'>website</a>",
              null);
          emailSender.SendEmail(message);
        }
        return result;
      }
      catch(Exception)
      {
        return false;
      }
    }
    public async System.Threading.Tasks.Task<bool> SendEmailAsync(ResetPasswordModel resetPasswordModel)
    {
      try {
        var user = userService.GetUser(resetPasswordModel.Email);
        if(user != null)
        {
          var token = authService.MakeToken(user, false);
          var message = new Message(new string[] { user.Email },
            "Reset password token", $"<a href='{frontConfiguration.AddressFront}/recovery-password/{token}'>Recovery password</a>",
            null);
          await emailSender.SendEmailAsync(message);
          return true;
        }
        else
        {
          throw new NullReferenceException();
        }
      }
      catch(Exception)
      {
        return false;
      }
    }
  }
}

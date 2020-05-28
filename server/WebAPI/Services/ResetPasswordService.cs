using System;
using WebAPI.DTO;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
  public class ResetPasswordService
  {
    private readonly IEmailSender _emailSender;
    private readonly UserService _userService;
    private readonly FrontConfiguration _frontConfiguration;
    public ResetPasswordService(UserService userService,
        IEmailSender emailSender, FrontConfiguration frontConfiguration)
    {
      _userService = userService;
      _emailSender = emailSender;
      _frontConfiguration = frontConfiguration;
    }
    public bool UpdatePassword(RecoveryPasswordModel recoveryPasswordModel)
    {
      try
      {
        if(recoveryPasswordModel.Password == "" &&
          recoveryPasswordModel.Token == "" && 
          recoveryPasswordModel.Password.Length >= 8)
        {
          if(recoveryPasswordModel.Password == "")
          {
            throw new ArgumentException("password is empty", "Password");
          }
          if(recoveryPasswordModel.Token == "")
          {
            throw new ArgumentException("token is empty", "Token");
          }
          if(recoveryPasswordModel.Password.Length >= 8)
          {
            throw new ArgumentException("password lengt mus be >= 8", "password");
          }
        }
        var user = _userService.GetUserByRecoveryPasswordToken(recoveryPasswordModel.Token);
        if(user != null)
        {
          var result = _userService.UpdateUserPassword(user.Email, recoveryPasswordModel.Password);
          if(result)
          {
          _userService.DeleteRecoveryPasswordToken(recoveryPasswordModel.Token);
            var message = new Message(new string[] { user.Email },
                "Reset password token", "Your password has been changed successfully. " +
                $"Please check our <a href = '{_frontConfiguration.AddressFront}'>website</a>",
                null);
            _emailSender.SendEmail(message);
          }
          return result;
        }
        else
        {
          throw new ArgumentException("invalid token", "token");
        }
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.Message + e.ParamName);
        throw new Exception();
      }
      catch(Exception)
      {
        return false;
      }
    }
    public async System.Threading.Tasks.Task<bool> SendEmailAsync(RecoveryPasswordModel resetPasswordModel)
    {
      try {
        var user = _userService.GetUser(resetPasswordModel.Email);
        if(user != null)
        {
          _userService.CreateRecoveryPasswordToken(resetPasswordModel.Email);
          var token = user.ResetPasswordToken;
          var message = new Message(new string[] { user.Email },
            "Reset password token", $"<a href='{_frontConfiguration.AddressFront}/recovery-password/{token}'>Recovery password</a>",
            null);
          await _emailSender.SendEmailAsync(message);
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

using System;
using WebAPI.DTO;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
  public class ResetPasswordService
  {
    private readonly IEmailSender _emailSender;
    private readonly UserService _userService;
    private readonly AuthService _authService;
    private readonly FrontConfiguration _frontConfiguration;
    public ResetPasswordService(UserService userService,
        IEmailSender emailSender, AuthService authService, FrontConfiguration frontConfiguration)
    {
      _userService = userService;
      _emailSender = emailSender;
      _authService = authService;
      _frontConfiguration = frontConfiguration;
    }
    public bool UpdatePass(ResetPasswordModel resetPasswordModel)
    {
      try
      {
        if(resetPasswordModel.Email == "" &&
          resetPasswordModel.Password == "" &&
          resetPasswordModel.Token == "" && 
          resetPasswordModel.Password.Length >= 8)
        {
          if(resetPasswordModel.Email == "")
          {
            throw new ArgumentException("email is empty", "Email");
          }
          if(resetPasswordModel.Password == "")
          {
            throw new ArgumentException("password is empty", "Password");
          }
          if(resetPasswordModel.Token == "")
          {
            throw new ArgumentException("token is empty", "Token");
          }
          if(resetPasswordModel.Password.Length >= 8)
          {
            throw new ArgumentException("password lengt mus be >= 8", "password");
          }
        }
        var user = _userService.GetUser(resetPasswordModel.Email);
        if(user != null && user.Password == resetPasswordModel.Token)
        {
          var result = _userService.UpdateUserPassword(resetPasswordModel.Email, resetPasswordModel.Password);
          if(result)
          {
            var message = new Message(new string[] { resetPasswordModel.Email },
                "Reset password token", "Your password has been changed successfully. " +
                $"Please check our <a href = '{_frontConfiguration.AddressFront}'>website</a>",
                null);
            _emailSender.SendEmail(message);
          }
          return result;
        }
        else
        {
          throw new ArgumentException("token or email is not valid", "token");
        }
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.Message + e.ParamName);
        throw;
      }
      catch(Exception)
      {
        return false;
      }
    }
    public async System.Threading.Tasks.Task<bool> SendEmailAsync(ResetPasswordModel resetPasswordModel)
    {
      try {
        var user = _userService.GetUser(resetPasswordModel.Email);
        if(user != null)
        {
          var token = user.Password;
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
  public class RecoveryPasswordService
  {
    private readonly IEmailSender _emailSender;
    private readonly UserService _userService;
    private readonly FrontConfiguration _frontConfiguration;
    public RecoveryPasswordService(UserService userService,
        IEmailSender emailSender, FrontConfiguration frontConfiguration)
    {
      _userService = userService;
      _emailSender = emailSender;
      _frontConfiguration = frontConfiguration;
    }
    public async Task UpdatePasswordAsync(UpdatePasswordModel updatePasswordModel)
    {
      var results = new List<ValidationResult>();
      var context = new ValidationContext(updatePasswordModel);
      try
      {
        if(!Validator.TryValidateObject(updatePasswordModel, context, results, true))
        {
          foreach(var error in results)
          {
            Console.WriteLine(error.ErrorMessage);
          }
          throw new ArgumentException();
        }
        else
        {
          var user = await Task.Run(() => _userService.GetUserByRecoveryPasswordToken(updatePasswordModel.Token));
          if(user != null)
          {
            var result = _userService.UpdateUserPassword(user.Email, updatePasswordModel.Password);
            if(result)
            {
              _userService.DeleteRecoveryPasswordToken(updatePasswordModel.Token);
              var message = new Message(new string[] { user.Email },
                  "Reset password token", "Your password has been changed successfully. " +
                  $"Please check our <a href = '{_frontConfiguration.AddressFront}'>website</a>",
                  null);
              await _emailSender.SendEmailAsync(message);
            }
          }
          else
          {
            throw new ArgumentException("invalid token", "token");
          }
        }
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.Message);
        return;
      }
      catch(Exception)
      {
        return;
      }
    }
    public async Task SendEmailAsync(RecoveryPasswordModel recoveryPasswordModel)
    {
      var results = new List<ValidationResult>();
      var context = new ValidationContext(recoveryPasswordModel);
      try {

        if(!Validator.TryValidateObject(recoveryPasswordModel, context, results, true))
        {
          foreach(var error in results)
          {
            Console.WriteLine(error.ErrorMessage);
          }
          throw new ArgumentException();
        }
        else
        {
          var user = _userService.GetUser(recoveryPasswordModel.Email);
          if(user != null)
          {
            _userService.CreateRecoveryPasswordToken(recoveryPasswordModel.Email);
            var token = user.ResetPasswordToken;
            var message = new Message(new string[] { user.Email },
              "Reset password token", $"<a href='{_frontConfiguration.AddressFront}/recovery-password/{token}'>Recovery password</a>",
              null);
            await _emailSender.SendEmailAsync(message);
            return;
          }
          else
          {
            throw new NullReferenceException();
          }
        }
      }
      catch(Exception)
      {
        return;
      }
    }
  }
}

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
          string errors = "";
          foreach(var error in results)
          {
            errors += error.ErrorMessage;
          }
          throw new ArgumentException(errors);
        }
        else
        {
          var user = _userService.GetUser(recoveryPasswordModel.Email);
          if(user != null)
          {
            _userService.CreateRecoveryPasswordToken(recoveryPasswordModel.Email);
            var token = user.ResetPasswordToken;
            var message = new Message(new string[] { user.Email },
              "Reset password",
              "<div style='background-color:white;'><h5 style='font-family:Open Sans;font-style:normal;font-weight:600;font-size:18px;" +
              "line-height:150%;text-align:center;color:#0F0E0E;'>Recovery password</h5>" +
              "<div style='font-family:Open Sans;font-style:normal;font-weight:normal;font-size:14px;line-height:135%;color:#0F0E0E;'>" +
              "You made a request to restore your forgotten password on the MakeMeTrip website.</div>" +
              "<div style='font-family:Open Sans;font-style:normal;font-weight:normal;font-size:14px;line-height:135%;color:#0F0E0E;'>" +
              "To restore your password, please follow the link below:</div>" +
              "<div style='background:#03A9F4;border-radius:20px;width:250px;height:39px;display:flex;" +
              "align-items:center;justify-content:center;margin:auto;'>" +
              "<a style='color:#FFFFFF;text-decoration:none;margin:auto;'" +
              $"href={_frontConfiguration.AddressFront}/recovery-password/{token}>Recovery password</a></div>" +
              "<div style='color:#0F0E0E;font-family:Open Sans;font-style:normal;font-weight:normal;font-size:14px;line-height:135%;'>" +
              "If you did not make a request to restore your password, just ignore this email, and the password will not be changed.</div>" +
              "<div style='color:#0F0E0E;font-family:Open Sans;font-style:normal;font-weight:normal;font-size:14px;line-height:135%;'>" +
              "Your password is stored in a secure place and is not accessible to third parties.</div>" +
              "<div style='color:#0F0E0E;font-family:Open Sans;font-style:normal;font-weight:600;font-size:14px;line-height:135%;'>" +
              "With best respect, MakeMeTrip team</div></div>",
              null);
            await _emailSender.SendEmailAsync(message);
            return;
          }
          else
          {
            throw new NullReferenceException("User is null");
          }
        }
      }
      catch(Exception e)
      {
        throw e;
      }
    }
  }
}

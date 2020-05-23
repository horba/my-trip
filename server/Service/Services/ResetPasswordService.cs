using System;
using System.Collections.Generic;
using System.Text;
using Service.Interfaces;
using Services.Models;
using WebAPI.Services;

namespace Services.ResetPasswordService
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
  }
}

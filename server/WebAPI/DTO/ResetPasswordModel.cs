﻿namespace WebAPI.DTO
{
  public class ResetPasswordModel
  {
    public string Password { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }
  }
}

using System;
using System.Linq;
using System.Security.Claims;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO.UserSettings;
using WebAPI.Extension;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class UserSettingsController : ControllerBase
  {
    private readonly UserRepository _userRepository;
    private readonly UserService _userService;

    public UserSettingsController(UserRepository userRepository, UserService userService)
    {
      _userRepository = userRepository;
      _userService = userService;
    }

    [HttpGet]
    public IActionResult GetSettings()
    {
      int id = HttpContext.GetUserIdFromClaim();

      var user = _userRepository.FindUserById(id);
      if (user == null)
      {
        return StatusCode(500);
      }

      return Ok(_userService.ConvertUserToUserSettingsDTO(user));
    }

    [HttpPut]
    public IActionResult UpdateSettings(UserSettingsDTO userSettings)
    {
      int id = HttpContext.GetUserIdFromClaim();

      var user = _userRepository.FindUserById(id);
      if (user == null)
      {
        return StatusCode(500);
      }

      var userWithThisEmail = _userRepository.FindUserByEmail(userSettings.Email);

      if (userWithThisEmail != null && userWithThisEmail.Id != id)
      {
        return BadRequest(new { isEmailUsed = true });
      }

      _userService.ApplyUserSettingsDTOToUser(user, userSettings);
      _userRepository.UpdateUser(user);
      return Ok();
    }

  }
}
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI.DTO.UserSettings;
using WebAPI.Extension;
using WebAPI.Services;
using WebAPI.Services.Assets;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserSettingsController : ControllerBase
  {
    private readonly UserRepository _userRepository;
    private readonly UserService _userService;
    private readonly AssetsService _filesService;

    public UserSettingsController(UserRepository userRepository, UserService userService, AssetsService filesService)
    {
      _userRepository = userRepository;
      _userService = userService;
      _filesService = filesService;
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

      if (string.IsNullOrEmpty(userSettings.AvatarFileName))
      {
        _filesService.DeleteFile(user.AvatarFileName, AssetType.UserAvatar);
      }
      else if (!string.IsNullOrEmpty(user.AvatarFileName) && !user.AvatarFileName.Equals(userSettings.AvatarFileName, System.StringComparison.OrdinalIgnoreCase))
      {
        _filesService.DeleteFile(user.AvatarFileName, AssetType.UserAvatar);
      }

      _userService.ApplyUserSettingsDTOToUser(user, userSettings);
      _userRepository.UpdateUser(user);
      return Ok();
    }

  }
}
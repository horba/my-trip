using System;
using System.Linq;
using System.Security.Claims;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO.UserSettings;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSettingsController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserSettingsController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult GetSettings()
        {
            if (!Int32.TryParse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value, out var id))
            {
                return Forbid();
            }

            var user = _userRepository.FindUserById(id);
            if (user == null)
            {
                return StatusCode(500);
            }

            return Ok(new UserSettingsDTO(user));
        }

        [HttpPut]
        public IActionResult UpdateSettings(UserSettingsDTO userSettings)
        {
            if (!Int32.TryParse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value, out var id))
            {
                return Forbid();
            }

            var user = _userRepository.FindUserById(id);
            if (user == null)
            {
                return StatusCode(500);
            }

            var userWithThisEmail = _userRepository.FindUserByEmail(userSettings.Email);

            if (userWithThisEmail != null && userWithThisEmail.Id != id)
            {
                return BadRequest("Email is already taken");
            }

            userSettings.ApplyToUser(user);
            _userRepository.UpdateUser(user);
            return Ok();

        }

    }
}
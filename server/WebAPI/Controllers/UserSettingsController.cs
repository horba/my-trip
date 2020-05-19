using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO.UserSettings;

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

            return Ok(new UserSettingsResponse(user));
        }

        [HttpPut]
        public IActionResult UpdateSettings(UserSettingsRequest userSettings)
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

            try
            {
                userSettings.ApplyToUser(user);
                _userRepository.UpdateUser(user);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }

        }

    }
}
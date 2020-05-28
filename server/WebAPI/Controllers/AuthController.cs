using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Extension;
using WebAPI.Services;

namespace WebAPI.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class AuthController : Controller
  {
    private readonly UserService _userService;
    private readonly AuthService _authService;

    public AuthController(UserService userService, AuthService authService)
    {
      _userService = userService;
      _authService = authService;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Auth(AuthRequest authRequest)
    {
      var user = _userService.GetUser(authRequest.Email, authRequest.Password);
      if(user == null)
        return Unauthorized();

      var token = _authService.MakeToken(user);
      return Ok(new AuthResponse { AccessToken = token });
    }

    [HttpGet]
    public IActionResult getTest()
    {
      var id = HttpContext.GetUserIdFromClaim();
      return Ok($"Your id: {id}");
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("SignUp")]
    public IActionResult Registration(AuthRequest authRequest)
    {
      if(_userService.IsUserExist(authRequest.Email))
      {
        return UnprocessableEntity();
      }
      else
      {
        _userService.CreateUser(authRequest.Email, authRequest.Password);
        return Ok();
      }
    }
  }
}
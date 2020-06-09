using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.DTO.Auth;
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
    private readonly GoogleOauthService _googleOauthService;

    public AuthController(UserService userService, AuthService authService, GoogleOauthService googleOauthService)
    {
      _userService = userService;
      _authService = authService;
      _googleOauthService = googleOauthService;
    }

    [AllowAnonymous]
    [HttpPost]
    public IActionResult Auth(AuthRequest authRequest)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      var user = _userService.GetUser(authRequest.Email, authRequest.Password);
      if (user == null)
        return Unauthorized();

      var token = _authService.MakeToken(user);
      return Ok(new AuthResponse { AccessToken = token });
    }

    [AllowAnonymous]
    [HttpPost("google")]
    public async Task<IActionResult> AuthWithGoogle(GoogleOauthDTO gAuth)
    {
      string googleBearer = await _googleOauthService.GetToken(gAuth.Code);
      var emailUserId = await _googleOauthService.GetGoogleUserData(googleBearer);
      
      if (emailUserId.Key == null)
      {
        return Unauthorized();
      }

      var user = _userService.GetUser(emailUserId.Key);

      if (user == null)
      {
        _userService.CreateGoogleOauthUser(emailUserId.Key, emailUserId.Value);
        user = _userService.GetUser(emailUserId.Key);
      }

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
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      if (_userService.IsUserExist(authRequest.Email))
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
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace WebAPI.Extension
{
  public static class HttpContextExtensions
  {
    public static int GetUserIdFromClaim(this HttpContext httpContext)
    {
      var claim = httpContext?.User?.FindFirst(ClaimTypes.Name)?.Value;
      if (int.TryParse(claim, out var userId))
        return userId;
      return 0;
    }
  }
}

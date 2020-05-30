using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
  public class GooleOauthConfiguration
  {
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string RedirectUrl { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO.Auth
{
  public class GoogleOauthDTO
  {
    [Required]
    public string Code { get; set; }
  }
}

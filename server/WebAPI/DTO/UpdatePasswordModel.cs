using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
  public class UpdatePasswordModel
  {
    [Required]
    [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
    public string Password { get; set; }
    [Required]
    [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 10)]
    public string Token { get; set; }
  }
}

using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
  public class RecoveryPasswordModel
  {
    [Required]
    [EmailAddress]
    public string Email { get; set; }
  }
}

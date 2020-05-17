using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class AuthRequest
    {
        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 10)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
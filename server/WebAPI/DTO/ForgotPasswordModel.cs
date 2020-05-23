using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

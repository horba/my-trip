using System.ComponentModel.DataAnnotations;

namespace Service.Models
{
    public class ResetPasswordModel
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

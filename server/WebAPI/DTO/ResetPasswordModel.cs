using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class ResetPasswordModel
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models.Enums;

namespace Entities.Models
{
    [Table("users")]
    public class User
    {
        public User()
        {
            Gender = Gender.NotSpecified;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Gender Gender { get; set; }
    }
}

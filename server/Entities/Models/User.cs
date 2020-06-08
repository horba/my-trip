using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public string GoogleId { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Gender Gender { get; set; }
    public Language Language { get; set; }
    public Country Country { get; set; }

    public string ResetPasswordToken { get; set; }

    public ICollection<Ticket> Tickets  { get; set; }

    public string AvatarFileName { get; set; }
  }
}

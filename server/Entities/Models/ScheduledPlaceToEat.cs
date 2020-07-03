using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("scheduledPlaceToEat")]
  public class ScheduledPlaceToEat
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public DateTime DateTime { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(200, ErrorMessage = "The length {0} must be from 1 to {1}.")]
    public string NamePlace { get; set; }

    [StringLength(2000, ErrorMessage = "The length {0} must be from 0 to {1}.")]
    public string Notes { get; set; }

    [DataType(DataType.Url, ErrorMessage = "It doesn't look like a url")]
    public string Link { get; set; }

    [StringLength(50, ErrorMessage = "The length {0} must be from 0 to {1}.")]
    public string GooglePlaceId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }
  }
}

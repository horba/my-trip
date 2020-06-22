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
    [StringLength(200, ErrorMessage = "{0} length must be up to {1}.")]
    public string NamePlace { get; set; }

    [StringLength(2000, ErrorMessage = "{0} length must be up to {1}.")]
    public string Notes { get; set; }

    [DataType(DataType.Url, ErrorMessage = "It doesn't look like a link")]
    public string Link { get; set; }

    [StringLength(50, ErrorMessage = "{0} length must be up to {1}.")]
    public string GooglePlaceId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public IEnumerable<AttachmentFileEating> Attachments { get; set; }
  }
}

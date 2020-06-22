using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("attachmentFileEating")]
  public class AttachmentFileEating
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Path { get; set; }

    [Required]
    public int ScheduledPlaceToEatId { get; set; }

    [ForeignKey("ScheduledPlaceToEatId")]
    public ScheduledPlaceToEat ScheduledPlaceToEat { get; set; }
  }
}
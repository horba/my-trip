using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebAPI.DTO.ScheduledPlaceToEat
{
  public class AttachmentFileEatingDTO
  {
    public int Id { get; set; }

    [Required]
    public IFormFile File { get; set; }

    public string FileName { get; set; }
  }
}

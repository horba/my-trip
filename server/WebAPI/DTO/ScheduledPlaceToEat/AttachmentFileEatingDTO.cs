using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebAPI.DTO.ScheduledPlaceToEat
{
  public class AttachmentFileEatingDTO
  {
    public int Id { get; set; }

    public string Path { get; set; }
  }
}

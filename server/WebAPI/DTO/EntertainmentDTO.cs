using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
  public class EntertainmentDTO
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string PlaceId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [MaxLength(280)]
    public string Note { get; set; }

    [Range(0, 30)]
    public int PeopleCount { get; set; }

    [Required]
    public DateTime VisitDate { get; set; }
    public double? LocationLat { get; set; }
    public double? LocationLng { get; set; }
    public string EntertainmentFilePath { get; set; }

  }
}

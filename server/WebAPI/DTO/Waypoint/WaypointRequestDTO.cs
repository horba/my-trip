using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Enums;
using WebAPI.Validators;

namespace WebAPI.DTO.Waypoint
{
  public class WaypointRequestDTO
  {
    [Required]
    public string DepartureCity { get; set; }
    [Required]
    public DateTime? DepartureDate { get; set; }

    [Required]
    public string ArrivalCity { get; set; }
    [Required]
    public DateTime? ArrivalDate { get; set; }

    [Required]
    public string PathTime { get; set; }
    [Required]
    public int? PathLength { get; set; }

    public string Details { get; set; }

    [Required]
    public int? TripId { get; set; }
    public int NewId { get; set; }

    [ValidEnum]
    public TransportTypes Transport { get; set; }
  }
}

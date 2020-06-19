using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Enums;
using WebAPI.Validators;

namespace WebAPI.DTO.Waypoint
{
  public class WaypointRequestDTO
  {
    public string DepartureCity { get; set; }
    public DateTime DepartureDate { get; set; }

    public string ArrivalCity { get; set; }
    public DateTime ArrivalDate { get; set; }

    public string PathTime { get; set; }
    public int PathLength { get; set; }

    public string Details { get; set; }

    public int TripId { get; set; }
    public int NewId { get; set; }

    [ValidEnum]
    public TransportTypes Transport { get; set; }
  }
}

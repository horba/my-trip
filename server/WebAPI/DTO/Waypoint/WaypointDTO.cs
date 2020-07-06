using System;
using System.Collections.Generic;
using Entities.Models.Enums;
using WebAPI.DTO.Waypoint;

namespace WebAPI.DTO
{
  public class WaypointDTO
  {
    public int Id { get; set; }

    public string City { get; set; }

    public string DepartureDate { get; set; }
    public string ArrivalDate { get; set; }

    public TimeSpan PathTime { get; set; }
    public int PathLength { get; set; }

    public string Details { get; set; }

    public TransportTypes Transport { get; set; }

    public bool IsCompleted { get; set; }
    public bool IsDetails { get; set; }

    public string ImageUrl { get; set; }

    public IEnumerable<WaypointFileDTO> Files { get; set; }
  }
}

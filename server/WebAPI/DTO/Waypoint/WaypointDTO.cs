using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models.Enums;

namespace WebAPI.DTO
{
  public class WaypointDTO
  {
    public int Id { get; set; }

    public string City { get; set; }

    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }

    public TimeSpan PathTime { get; set; }
    public int PathLength { get; set; }

    public string Details { get; set; }

    public TransportTypes Transport { get; set; }

    public bool IsCompleted { get; set; }
    public bool IsDetails { get; set; }
  }
}

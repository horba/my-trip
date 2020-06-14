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

    public int Order { get; set; }

    public string City { get; set; }

    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }

    public TimeSpan PathTime { get; set; }
    public int PathLength { get; set; }

    public string Details { get; set; }

    public TransportTypes Transport { get; set; }

    public bool IsCompleted { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Entities.Models.Enums;

namespace Entities.Models
{
  public class Waypoint
  {
    public int Id { get; set; }

    [ForeignKey("Trip")]
    public int TripId { get; set; }
    public Trip Trip { get; set; }

    public int Order { get; set; }

    public string City { get; set; }

    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }

    public TimeSpan PathTime { get; set; }
    public int PathLength { get; set; }

    public string Details { get; set; }

    public TransportTypes Transport { get; set; }

    public bool IsCompleted { get; set; }
    public bool IsDetails { get; set; }

    public string ImageUrl { get; set; }
  }
}

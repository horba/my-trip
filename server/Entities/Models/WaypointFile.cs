using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  public class WaypointFile
  {
    public int Id { get; set; }

    [ForeignKey("Waypoint")]
    public int WaypointId { get; set; }

    public string UserFileName { get; set; }
    public string ActualFileName { get; set; }
  }
}

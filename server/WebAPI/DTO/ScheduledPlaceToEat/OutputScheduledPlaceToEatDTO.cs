using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.DTO.ScheduledPlaceToEat
{
  public class OutputScheduledPlaceToEatDTO
  {
    public int Id { get; set; }

    public DateTime DateTime { get; set; }

    public string PlaceName { get; set; }

    public string Notes { get; set; }

    public string Link { get; set; }

    public string GooglePlaceId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public IEnumerable<string> FileNames { get; set; }
  }
}

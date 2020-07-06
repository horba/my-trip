using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO.Accommodation
{
  public class AccommodationFilterQueryDTO
  {
    public int? Year { get; set; }

    public int? MinPrice { get; set; }
    public int? MaxPrice { get; set; }

    public string Countries { get; set; }
  }
}

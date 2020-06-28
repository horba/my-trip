using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO.ScheduledPlaceToEat
{
  public class InputScheduledPlaceToEatForUpdateOrDeleteDTO
  {
    [Required(ErrorMessage = "{0} is required")]
    public int Id { get; set; }

    public int UserId { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public DateTime DateTime { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(200, ErrorMessage = "{0} length must be up to {1}.")]
    public string NamePlace { get; set; }

    [StringLength(2000, ErrorMessage = "{0} length must be up to {1}.")]
    public string Notes { get; set; }

    [DataType(DataType.Url, ErrorMessage = "It doesn't look like a link")]
    public string Link { get; set; }

    [StringLength(50, ErrorMessage = "{0} length must be up to {1}.")]
    public string GooglePlaceId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }
  }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO.ScheduledPlaceToEat
{
  public class InputScheduledPlaceToEatForCreateDTO
  {
    public int UserId { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    public DateTime DateTime { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [StringLength(200, ErrorMessage = "{0} length must be up to {1}.")]
    public string PlaceName { get; set; }

    [StringLength(2000, ErrorMessage = "{0} length must be up to {1}.")]
    public string Notes { get; set; }

    [DataType(DataType.Url, ErrorMessage = "It doesn't look like a link")]
    public string Link { get; set; }

    [StringLength(300, ErrorMessage = "{0} length must be up to {1}.")]
    public string GooglePlaceId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }
  }
}

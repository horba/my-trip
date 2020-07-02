using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
  public class AccommodationDTO
  {
    public int Id { get; set; }

    public int UserId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    public DateTime DepartureDateTime { get; set; }

    [Required]
    public DateTime ArrivalDateTime { get; set; }

    [Required]
    [MaxLength(500)]
    public string Address { get; set; }

    [Range(0, 30)]
    public int GuestCount { get; set; }

    [Range(0, 15)]
    public int RoomsCount { get; set; }

    [RegularExpression("^(https?|http)://[^\\s/$.?#].[^\\s]*$")]
    public string Link { get; set; }

    [MaxLength(2000)]
    public string Note { get; set; }

    public decimal? Rating { get; set; }

    public decimal? RatingTotal { get; set; }

    [Range(1, 1000000)]
    public decimal Price { get; set; }

    public string Currency { get; set; }

    public List<string> Photos { get; set; }

    public decimal TotalPrice => (int)(DepartureDateTime - ArrivalDateTime).TotalDays * Price * RoomsCount;
  }
}

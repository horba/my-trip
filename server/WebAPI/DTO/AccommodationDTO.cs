using System;
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

    public string Link { get; set; }

    [MaxLength(2000)]
    public string Note { get; set; }

    public decimal? Rating { get; set; }

    public decimal? RatingTotal { get; set; }

    public int? PriceLevel { get; set; }

    public decimal? LocationLat { get; set; }
    public decimal? LocationLng { get; set; }

    public string[] Photos { get; set; }

    public string GooglePlaceId { get; set; }
  }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO.Trip
{
  public class TripRequestDTO
  {
    [Required]
    public int? DepartureCountryId { get; set; }
    [Required]
    public string DepartureCity { get; set; }
    [Required]
    public DateTime? DepartureDate { get; set; }

    [Required]
    public int? ArrivalCountryId { get; set; }
    [Required]
    public DateTime? ArrivalDate { get; set; }

    [Required]
    public decimal? TotalPrice { get; set; }
    [Required]
    public string Currency { get; set; }

    [Required]
    public string FlightTime { get; set; }
    [Required]
    public string TransplantTime { get; set; }
    [Required]
    public string DifferenceInTime { get; set; }
  }
}

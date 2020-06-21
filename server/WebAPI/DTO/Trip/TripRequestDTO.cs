using System;

namespace WebAPI.DTO.Trip
{
  public class TripRequestDTO
  {
    public int DepartureCountryId { get; set; }
    public string DepartureCity { get; set; }
    public DateTime DepartureDate { get; set; }

    public int ArrivalCountryId { get; set; }
    public DateTime ArrivalDate { get; set; }

    public decimal TotalPrice { get; set; }
    public string Currency { get; set; }

    public string FlightTime { get; set; }
    public string TransplantTime { get; set; }
    public string DifferenceInTime { get; set; }
  }
}

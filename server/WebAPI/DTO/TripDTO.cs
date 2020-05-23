using System;

namespace WebAPI.DTO
{
  public class TripDTO
  {
    public int Id { get; set; }
    public CountryDTO DepartureCountry { get; set; }
    public string DepartureCity { get; set; }
    public CountryDTO ArrivalCountry { get; set; }
    public DateTime StartDate { get; internal set; }
    public DateTime EndDate { get; internal set; }
    public decimal TotalPrice { get; set; }
    public string Currency { get; set; }
    public string FlightTime { get; set; }
    public string TransplantTime { get; set; }
    public string DifferenceInTime { get; set; }
    public string ImageUrl { get; set; }
  }
}

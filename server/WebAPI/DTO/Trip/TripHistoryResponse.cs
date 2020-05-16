using Entities.Models;
using System;

namespace WebAPI.DTO.Trip
{
  public class TripHistoryResponse
  {
    public int Id { get; set; }
    public Country DepartureCountry { get; set; }
    public string DepartureCity { get; set; }
    public Country ArrivalCountry { get; set; }
    public DateTime StartDate { get; internal set; }
    public DateTime EndDate { get; internal set; }
    public decimal TotalPrice { get; set; }
    public string Currency { get; set; }

    public string FlightTime { get; set; }
    public string DifferenceInTime { get; set; }

    public string ImageUrl { get; set; }
  }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("trips")]
  public class Trip
  {
    public int Id { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    public int DepartureCountryId { get; set; }
    [ForeignKey("DepartureCountryId")]
    public Country DepartureCountry { get; set; }
    public string DepartureCity { get; set; }

    public int ArrivalCountryId { get; set; }
    [ForeignKey("ArrivalCountryId")]
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

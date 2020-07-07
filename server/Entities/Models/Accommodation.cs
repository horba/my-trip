using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("accommodations")]
  public class Accommodation
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }

    [ForeignKey("Country")]
    public int CountryId { get; set; }

    public string Name { get; set; }

    public DateTime DepartureDateTime { get; set; }
    
    public DateTime ArrivalDateTime { get; set; }
    
    public string Address { get; set; }
   
    public int GuestCount { get; set; }
   
    public int RoomsCount { get; set; }

    public string Link { get; set; }
    
    public string Note { get; set; }

    public decimal? Rating { get; set; }

    public decimal? RatingTotal { get; set; }

    public decimal Price { get; set; }

    public string Currency { get; set; }

    public string Photos { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  [Table("entertainments")]
  public class Entertainment
  {

    [Key]
    public int Id { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public string PlaceId { get; set; }
    public string Title { get; set; }
    public string Note { get; set; }
    public int PeopleCount { get; set; }
    public DateTime VisitDate { get; set; }
    public double? LocationLat { get; set; }
    public double? LocationLng { get; set; }
    public string EntertainmentFilePath { get; set; }

  }
}

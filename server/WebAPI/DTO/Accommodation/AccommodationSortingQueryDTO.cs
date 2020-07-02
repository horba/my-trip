using Entities.Models.Enums;
using WebAPI.Validators;

namespace WebAPI.DTO.Accommodation
{
  public class AccommodationSortingQueryDTO
  {
    [ValidEnum]
    public AccommodationSortBy SortByBy { get; set; }
    
    [ValidEnum]
    public SortDirection SortDirection { get; set; }
  }
}

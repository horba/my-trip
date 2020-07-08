using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
  public class PaginationRequestDTO
  {

    [Required]
    [Range(0, Int32.MaxValue)]
    public int? PageNumber { get; set; }

    [Required]
    [Range(1, 24)]
    public int? PageSize { get; set; }

  }
}

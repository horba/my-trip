using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
  public class PaginationRequestQueryDTO
  {
    [Required]
    [Range(0, Int32.MaxValue)]
    public int? PageNumber { get; set; }

    [Required]
    [Range(0, Int32.MaxValue)]
    public int? PageSize { get; set; }
  }
}

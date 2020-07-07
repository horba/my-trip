using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
  public class PagedResponse<T>
  {
    public IEnumerable<T> Data { get; set; }

    public int? PageNumber { get; set; }

    public int? PageSize { get; set; }

    public int? TotalCount { get; set; }
  }
}
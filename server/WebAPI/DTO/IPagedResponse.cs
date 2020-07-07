using System.Collections.Generic;

namespace WebAPI.DTO
{
  public class IPagedResponse<T>
  {
    public IEnumerable<T> Data { get; set; }

    public int? PageNumber { get; set; } // номер текущей страницы

    public int? PageSize { get; set; } // размер страницы или пагинации - сколько элементов подгружается за страницу

    public int? PageCount { get; set; } // сколько всего страниц

    public int? TotalCount { get; set; } // cколько всего элементов
  }
}

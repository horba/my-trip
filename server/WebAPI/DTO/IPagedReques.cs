using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
  public class IPagedReques
  {
    [Required, Range(0, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int? Page { get; set; } // номер текущей страницы

    [Required, Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int? PageSize { get; set; } // размер страницы или пагинации - сколько элементов вернуть на странице
  }
}

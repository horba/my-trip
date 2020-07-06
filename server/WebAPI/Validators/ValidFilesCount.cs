using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace WebAPI.Validators
{
  public class ValidFilesCount : ValidationAttribute
  {
    public ValidFilesCount(int count) => Count = count;

    public int Count { get; }

    public string GetErrorMessage() =>
      $"The files count must not exceed {Count}, but more 0.";

    public override bool IsValid(object value) => base.IsValid(value);
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if(value is IFormFileCollection file)
      {
        if(file.Count > Count && file.Count == 0)
        {
          return new ValidationResult(GetErrorMessage());
        }
      }
      else if(value is IEnumerable<IFormFile> enumerableFile)
      {
        if(enumerableFile.Count() > Count && enumerableFile.Count() == 0)
        {
          return new ValidationResult(GetErrorMessage());
        }
      }
      return ValidationResult.Success;
    }
  }
}

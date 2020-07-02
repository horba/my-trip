using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace WebAPI.Validators
{
  public class ValidFileType : ValidationAttribute
  {
    public ValidFileType(string[] types) => Types = types;

    public string[] Types { get; }

    public string GetErrorMessage() =>
      $"The file type must be one of type: {Types}";

    public override bool IsValid(object value) => base.IsValid(value);
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if(value is IFormFile file)
      {
        if(Types.Where(type => type.Contains(file.ContentType, StringComparison.OrdinalIgnoreCase)) is null)
        {
          return new ValidationResult(GetErrorMessage());
        }
      }
      return ValidationResult.Success;
    }
  }
}

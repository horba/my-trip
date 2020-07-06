using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

public class ValidFileSize : ValidationAttribute
{
  public ValidFileSize(int size)
  {
    Size = size;
  }

  public int Size { get; }

  public string GetErrorMessage() =>
      $"The file size must not exceed {Size} bytes.";

  protected override ValidationResult IsValid(object value,
      ValidationContext validationContext)
  {
    if(value is IFormFile file)
    {
      if(file.Length > Size)
        return new ValidationResult(GetErrorMessage());
    }
    return ValidationResult.Success;
  }
}

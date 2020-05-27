using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Validators
{
    public class Enumable : ValidationAttribute
    {
        private readonly Type _enumType;

        public Enumable(Type enumType)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{enumType} is not compatible with Enum");
            }
            _enumType = enumType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is string))
            {
                throw new ArgumentException("This attribute must be applied only to string");
            }

            Enum.TryParse(_enumType, (string)value, true, out var enumValue);
            if (enumValue != null && Enum.IsDefined(_enumType, enumValue))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Cannot convert to enum");

        }
    }
}

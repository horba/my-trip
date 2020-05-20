using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Validators
{
    public class ValidEnum : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is Enum))
            {
                return new ValidationResult("This type is not compatible with Enum");
            }

            if (!Enum.IsDefined(value.GetType(), value))
            {
                return new ValidationResult("Enum is out of range");
            }

            return ValidationResult.Success;
        }
    }
}

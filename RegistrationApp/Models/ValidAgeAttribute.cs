using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class ValidAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            if (value is int)
            {
                if (value is >= 18)
                {
                    if (value is <= 120)
                    {
                        return ValidationResult.Success;
                    }
                }
            }

            string msg = base.ErrorMessage ?? $"{ctx.DisplayName} must be a valid age over 18.";
            return new ValidationResult(msg);
        }

    }
}

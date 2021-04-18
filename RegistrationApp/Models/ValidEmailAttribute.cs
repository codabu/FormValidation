using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class ValidEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext ctx)
    {
            if (value is string)
            {
                string regex = @"^[^@\s]+@[^@\s\.]+\.[^@\.\s]+$";
                Regex rgx = new Regex(regex);
                if (rgx.IsMatch(value.ToString()))
                {
                    return ValidationResult.Success;
                }
                string msg = base.ErrorMessage ?? $"{ctx.DisplayName} must be valid";
                return new ValidationResult(msg);

            }
            else
            {
                string msg = base.ErrorMessage ?? $"{ctx.DisplayName} must be valid";
                return new ValidationResult(msg);
            }
        }

}
}

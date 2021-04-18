using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class ValidNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            string regex = @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$";
            Regex rgx = new Regex(regex);
            if (rgx.IsMatch(value.ToString()))
            {
                return ValidationResult.Success;
            }

            else 
            {
                string msg = base.ErrorMessage ?? $"{ctx.DisplayName} must be valid";
                return new ValidationResult(msg);
            }
        }

}
}

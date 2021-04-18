using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RegistrationApp.Models
{
    public class RegistrationModel
    {

        [Required(ErrorMessage = "Please enter a name")]
        [ValidName]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [ValidEmail]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [ValidAge]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select a contact preference")]
        public string ContactPreference { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult ViewFormData(RegistrationModel model)
        {
            return View(model);
        }
    }
}

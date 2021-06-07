using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessFormTask.Models;
using BusinessFormTask.ViewModel;

namespace BusinessFormTask.Controllers
{
    public class InputDataController : Controller
    {
        [BindProperty]
        public PersonPropertie PersonPropertie { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Output(PersonPropertie person)
        {
            if (ModelState.IsValid)
            {

                string Name = person.PersonFullName;
                string EMail = person.PersonEmail;
                return "Name: " + Name + "EMail: " + EMail;
            }
            return "Give Proper input";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

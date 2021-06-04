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
        public string Output(PersonPropertie person)
        {
            string Name = person.PersonFullName;
            string EMail = person.PersonEmail;
            return "Name: " + Name + "EMail: " + EMail;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

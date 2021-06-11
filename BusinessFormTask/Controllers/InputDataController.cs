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
        public JsonResult Output(PersonPropertie person)
        {
                //string Name = person.PersonFullName;
                //string EMail = person.PersonEmail;
                return Json(person);
            //if (ModelState.IsValid)
            //{

            //}
            //return "Give Proper input";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

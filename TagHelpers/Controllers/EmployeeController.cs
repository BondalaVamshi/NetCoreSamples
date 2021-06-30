using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Employee();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Employee model)
        {
            //ViewBag.EmpDetails = employee.ToString();

            return View(model);
        }
        
        [Route("/Employee/Emp",Name ="DifferentTags")]
        public IActionResult Emp()
        {
            return View();
        }
        [Route("/Employee/Evolution",Name ="RoutAllData")]
        public IActionResult Evolution(int EmployeeId, bool Trainee) => View();

        [Route("/Employee/AnchorTags", Name = "AnchorTags")]
        public IActionResult AnchorTags() => View();

        public IActionResult Cache() => View();
        public IActionResult Environment() => View();

        [HttpPost]
        public IActionResult EmpDetails(Employee employee)
        {
            return View(employee);
        }
    }

}

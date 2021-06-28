using Microsoft.AspNetCore.Mvc;
using System;
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
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            //ViewBag.EmpDetails = employee.ToString();

            return View();
        }
        
        public IActionResult Emp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmpDetails(Employee employee)
        {
            return View(employee);
        }
    }

}

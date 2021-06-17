using ActionResults.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionResults.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult ContentR()
        {
            return Content("This is the content result returns in string format");
        }
        public ObjectResult ObjectR()
        {
            var employee = new Employee { Id=1,Name = "Guru", Location = "Hyd" };
            return new ObjectResult(employee);
        }
        public EmptyResult EmptyR()
        {
            return new EmptyResult();
        }
        public ViewResult ViewR()
        {
            //return View("ContentR", "Employee");
            return View("IActionR");

        }
        //public ActionResult IActionR()
        //{
        //    return View();
        //}
        public IActionResult IActionR()
        {
            return View();
        }
        public PartialViewResult PartialViewR()
        {
            return PartialView("__PartialViewR");
        }
    }
}

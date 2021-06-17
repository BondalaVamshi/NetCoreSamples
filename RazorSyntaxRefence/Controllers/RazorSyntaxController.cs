using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSyntaxRefence.Controllers
{
    public class RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Conditional()
        {
            return View();
        }
        public IActionResult Loops()
        {
            return View();
        }
        public IActionResult OverviewRazor()
        {
            return View();
        }
    }
}

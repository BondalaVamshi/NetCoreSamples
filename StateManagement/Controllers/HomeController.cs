using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string SessionKeyName = "_Name";
        private string SessionKeyId = "_Age";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Login(Employee employee)
        {
            if (employee.Id==1&&employee.Name=="Ram")
            {
                CookieOptions cookie = new CookieOptions();
                
                Response.Cookies.Append(employee.Id.ToString(), employee.Name, cookie);
                ViewBag.CookieValue = Request.Cookies["cookie"];

                return RedirectToAction("WelCome");
            }
            else
            {
                return View();
            }
        }
        public IActionResult WelCome()
        {
            if (Request.Cookies["cookie"] != null)
            {
                return View();
            }
            else
            {
                ViewBag.CookieValue = "Not authentcated";
                return View();
            }

           
        }
        public IActionResult Index()
        {

            HttpContext.Session.SetString(SessionKeyName, "The Farmer name");
            HttpContext.Session.SetInt32(SessionKeyId, 123);
            
            HttpContext.Session.SetString("Test", "Session value is setting here");
            return View();
        }

        public IActionResult Privacy()
        {

            //ViewBag.SessionName = HttpContext.Session.GetString(SessionKeyName);
            //ViewBag.SessionId = HttpContext.Session.GetInt32(SessionKeyId);

            //ViewBag.SessionV = HttpContext.Session.GetString("Test");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

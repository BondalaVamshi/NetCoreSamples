using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Controllers
{
    public class DateAndTimeController : Controller
    {
        private readonly IDateTime _dateTime;
        public DateAndTimeController(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }
        public IActionResult Index()
        {
            var serverTime = _dateTime.Now;
            ViewData["serverTime"] = serverTime.TimeOfDay;
            if (serverTime.Hour< 12)
            {
                ViewData["Message"] = "Good morning world";
            }
            else if (serverTime.Hour<17)
            {
                ViewData["Message"] = "Good afternoon world";
            }
            else if(serverTime.Hour<19)
            {
                ViewData["Message"] = "Good evening world";
            }
            else
            {
                ViewData["message"] = "good night world";
            }
            return View();
        }
        //The FromServicesAttribute enables injecting a service directly into an
        //action method without using constructor injection
        public IActionResult UsingFromServices([FromServices] IDateTime dateTime)
        {
            return Content($"The time is {dateTime.Now.TimeOfDay}");
        }

    }
}

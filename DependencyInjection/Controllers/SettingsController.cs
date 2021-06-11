using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SampleWebSettings _sampleWeb;
        public SettingsController(IOptions<SampleWebSettings> sampleweb)
        {
            _sampleWeb = sampleweb.Value;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = _sampleWeb.Title;
            ViewData["Updates"] = _sampleWeb.Updates;
            return View();
        }
    }
}

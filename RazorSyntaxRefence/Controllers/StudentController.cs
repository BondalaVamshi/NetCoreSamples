﻿using Microsoft.AspNetCore.Mvc;
using RazorSyntaxRefence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSyntaxRefence.Controllers
{
    
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewsDataTransfor.Models;
using ViewsDataTransfor.ViewModel;


namespace ViewsDataTransfor.Controllers
{
    public class InputDataController : Controller
    {
        public IActionResult Index()
        {            
            InputDataOutput inputDataOutput = new InputDataOutput();
            return View(inputDataOutput);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitPerson(InputDataOutput inputDataOutput)
        {
            if (ModelState.IsValid)
            {
                TempData["inputOutput"] = inputDataOutput;
                return Redirect("/InputData/OutputView");
            }
            else
            {
                return View();
            }
        }        
        public IActionResult PersonDetails()
        {
            return Redirect("/InputData/OutputView");
        }        
        public IActionResult BusinessDetails()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        public IActionResult OutputView()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
            //TempData["inputOutput"] = inputDataOutput;
            // InputDataOutput inputDataOutput = TempData["inputOutput"] as InputDataOutput;
        }
    }
}

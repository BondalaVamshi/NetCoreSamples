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
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult SubmitPerson(PersonPropertie personPropertie)
        //{
        //    InputDataOutput inputDataOutput = new InputDataOutput();
        //    return Redirect("/InputData/OutputView");
            
        //}
        [HttpPost]
s
        public IActionResult PersonOutputView(PersonPropertie person)
        {
            //InputDataOutput inputDataOutput = TempData["inputOutput"] as InputDataOutput;
            //TempData["inputOutput"] = inputDataOutput;
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BusinessOutputView(BusinessPropertie business)
        {
            return View(business);
        }
        //public IActionResult PersonDetails()
        //{
        //    return Redirect("/InputData/BusinessDetails");
        //}        
        public IActionResult BusinessDetails()
        {
            return Redirect("/InputData/OutputView");
        }
    }
}

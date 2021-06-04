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
        
        public string Output(InputDataOutput  inputOutput)
        {
            InputDataOutput inputDataOutput = new InputDataOutput()
            {
                PersonPropertie = inputOutput.PersonFullName
            };
            return "Heloo";
            //string Name = inputDataOutput.PersonFullName;
            //string EMail = person.PersonEmail;
            //return "Name: " + Name + "EMail: " + EMail;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

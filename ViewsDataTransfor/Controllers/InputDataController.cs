using LocationRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult PersonOutputView(PersonPropertie person)
        {
                    //TempData["inputOutput"] = inputDataOutput;
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BusinessOutputView(BusinessPropertie business)
        {
            return View(business);
        }
      
        public IActionResult BusinessDetails()
        {
            return Redirect("/InputData/OutputView");
        }

        [HttpPost]
        public ActionResult LoadCountry()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country { CountryName = "India", CountryId = "ind" });
            countries.Add(new Country { CountryName = "China", CountryId = "chi" });
            countries.Add(new Country { CountryName = "UnitedSatesOfAmerica", CountryId = "usa" });
            ViewBag.Country = countries;
            //ViewData["Country"] = countries;
            return View();
        }
        [HttpPost]
        public ActionResult LoadStates(string CountryId)
        {
            List<State> states = new List<State>();
            switch (CountryId)
            {
                case "ind":
                    states.Add(new State { SateName = "Telangana", SateId = "ts" });
                    states.Add(new State { SateName = "AndraPradesh", SateId = "ap" });
                    states.Add(new State { SateName = "Maharashra", SateId = "mh" });
                    break;
                case "chi":
                    states.Add(new State { SateName = "Hainan", SateId = "hai" });
                    states.Add(new State { SateName = "Shandong", SateId = "sha" });
                    states.Add(new State { SateName = "Yunnan", SateId = "yun" });
                    break;
                case "usa":
                    states.Add(new State { SateName = "California", SateId = "cal" });
                    states.Add(new State { SateName = "Texas", SateId = "tex" });
                    states.Add(new State { SateName = "Florida", SateId = "flo" });
                    break;
            }
            return Json(new SelectList(states, "Value", "Text"));
        }
        [HttpPost]
        public IActionResult LoadCity(string SateId)
        {
            List<City> cities = new List<City>();
            switch (SateId)
            {
                case "ts":
                    cities.Add(new City { CityName = "Karimnagar", CityId = "knr" });
                    cities.Add(new City { CityName = "Hydarabad", CityId = "hyd" });
                    break;
                case "ap":
                    cities.Add(new City { CityName = "vijayawada", CityId = "vij" });
                    cities.Add(new City { CityName = "WestGodavari", CityId = "west" });
                    break;
                case "mh":
                    cities.Add(new City { CityName = "Mumbai", CityId = "mum" });
                    cities.Add(new City { CityName = "Pune", CityId = "pun" });
                    break;
                case "hai":
                    cities.Add(new City { CityName = "Haikou", CityId = "ha" });
                    cities.Add(new City { CityName = "Sanya", CityId = "san" });
                    break;
                case "sha":
                    cities.Add(new City { CityName = "Jinan", CityId = "jai" });
                    cities.Add(new City { CityName = "Zibo", CityId = "zib" });
                    break;
                case "yun":
                    cities.Add(new City { CityName = "yun", CityId = "yun" });
                    cities.Add(new City { CityName = "yun", CityId = "yun" });
                    break;
                case "cal":
                    cities.Add(new City { CityName = "LossAnjeles", CityId = "los" });
                    cities.Add(new City { CityName = "SiliconValley", CityId = "sil" });
                    break;
                case "tex":
                    cities.Add(new City { CityName = "Dallas", CityId = "dal" });
                    cities.Add(new City { CityName = "Housten", CityId = "hou" });
                    break;
                case "flo":
                    cities.Add(new City { CityName = "miami", CityId = "mia" });
                    cities.Add(new City { CityName = "Orlando", CityId = "orl" });
                    break;
            }
            return Json(new SelectList(cities, "Value", "Text"));
        }


    }
}

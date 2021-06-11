using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitTest.Models;

namespace UnitTest.Pages
{
    public class TemparatureModel : PageModel
    {
        public double temparatureCelcious;
        public double temparatureFahrenheit;
        //Temparature temparature = new Temparature();

        //public string TemparatureCelcious { get; private set; }

        //public string TemparatureCelcious { get; private set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            temparatureCelcious = Convert.ToDouble(Request.Form[TemparatureCelcious]);
            temparatureFahrenheit = Temparature.CelciousToFahreinheit(temparatureFahrenheit);
        }
    }
}

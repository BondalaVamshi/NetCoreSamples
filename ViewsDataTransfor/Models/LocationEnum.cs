
using System;
using System.ComponentModel.DataAnnotations;

namespace ViewsDataTransfor.Models
{
    public enum Country
    {
        [Display(Name = "India")]
        India,
        [Display(Name = "United States of America")]
        usa,
        [Display(Name = "United Kingdom")]
        uk,
        [Display(Name = "Australia")]
        Australia
    }
    public enum State
    {
        [Display(Name = "Telangana")]
        Telangana,
        [Display(Name = "AndraPradesh")]
        AndraPradesh,
        [Display(Name = "UtterPradesh")]
        UtterPradesh,
        [Display(Name = "Florida")]
        Florida,
        [Display(Name = "Texas")]
        Texas,
        [Display(Name = "Amsterdam")]
        Amsterdam
    }
    public enum City
    {
        [Display(Name = "Karimnagar")]
        Karimnagar,
        [Display(Name = "Kammam")]
        Kammam,
        [Display(Name = "Hyderabad")]
        Hyderabad,
        [Display(Name = "Lakno")]
        Lakno,
        [Display(Name = "Housten")]
        Housten,
        [Display(Name = "Dallas")]
        Dallas
    }
    public enum Intervel
    {
        [Display(Name = "Monthly")]
        Monthly,
        [Display(Name = "Quaterly")]
        Quaterly,
        [Display(Name = "HalfYearly")]
        HalfYearly,
        [Display(Name = "Yearly")]
        Yearly
    }
}


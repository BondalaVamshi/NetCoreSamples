using System;
using ViewsDataTransfor.Models;

namespace LocationRepository
{
    public class Country
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
    }
    public class State
    {
        public string SateId { get; set; }
        public string SateName { get; set; }

    }
    public class City
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
    }
    public class Location
    {
        public Country CountryProp { get; set; }
        public State StateProp {get ; set;}
        public City CityProp { get; set; }
    }

}
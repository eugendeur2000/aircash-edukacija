using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRestCountries
{
    class Country
    {
        public string Name { get; set; }
        public bool Independent { get; set; }
        public List<string> Capital  { get; set; }
        public string Flag { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public List<string> Continents { get; set; }
        public int Area { get; set; }
        public bool LandLocked { get; set; }
        public string TimeZones { get; set; }
        public List<string> Languages { get; set; }


    }
    class CountryName
    {
        public string Common { get; set; }
        public string Official { get; set; }

    }
}


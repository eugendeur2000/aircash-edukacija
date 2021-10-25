using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRestCountries
{
    class Country
    {
        public string Name { get; set; }
        public bool Independent { get; set; }
        public string Capital  { get; set; }
        public string Flag { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public List<string> Continents { get; set; }
        public decimal Area { get; set; }
        public bool LandLocked { get; set; }
        public List<string> Timezones { get; set; }
        public List<Language> Languages { get; set; }


    }
    class CountryName
    {
        public string Common { get; set; }
        public string Official { get; set; }

    }

    class Language
    {
        public string Iso639_1 { get; set; }
        public string Iso639_2 { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }

    }
}


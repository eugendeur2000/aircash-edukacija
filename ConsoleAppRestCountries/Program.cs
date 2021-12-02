using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;




namespace ConsoleAppRestCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().ConfigureAwait(true).GetAwaiter().GetResult();
            //Console.ReadKey();



        }

        static async Task Main()
        {

            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://restcountries.com/v2/all");
            //Console.WriteLine(result);
            var countries = JsonConvert.DeserializeObject<List<Country>>(result);
            Console.WriteLine("select");
            Console.WriteLine("1-all countries");
            Console.WriteLine("2-continent countires");
            Console.WriteLine("3-all population");
            Console.WriteLine("4-all population");
            Console.WriteLine("5-independent countries");
            Console.WriteLine("6-capital city");
            Console.WriteLine("7-all capital city");
            var selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    printAllCountries(countries);

                    break;

                case 2:
                    Console.WriteLine("Enter continent name");
                    var continent = Console.ReadLine();
                    printCountriesInContinent(countries, continent);
                    break;

                

                case 3:
                    printAllPopulation(countries);

                    break;

                case 4:
                    var Population = Convert.ToInt32(Console.ReadLine());
                    printFiltByPopulation(countries, Population);
                    break;

                case 5:
                    printAllIndependentCountries(countries);

                break;
                case 6:
                    printAllCapitalCity(countries);

                    break;

                case 7:
                    Console.WriteLine("Enter All Capital");
                    var Capital = Console.ReadLine();
                    searchCountryByCapital(countries, Capital);
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;






            }

        }
        static void printAllCountries(List<Country> countries)

        {
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }
        }
        static void printCountriesInContinent(List<Country> countries, string continentName)
        {

            countries = countries.Where(x => x.Region == continentName).ToList();
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }
        }
        static void printAllPopulation(List<Country> countries)

        {
            foreach (var country in countries)
            {
                Console.WriteLine(country.Population);
            }
        }
        static void printFiltByPopulation(List<Country> countries, int population)
        {

            countries = countries.Where(x => x.Population > population).ToList();
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }
        }

        
        static void printAllIndependentCountries(List<Country> countries)
        {
            countries = countries.Where(x => x.Independent == true).ToList();
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }
        }
    
        static void printAllCapitalCity(List<Country> countries)

        {
            foreach (var country in countries)
            {
                Console.WriteLine(country.Capital);
            }

        }
        static void searchCountryByCapital(List<Country> countries, string CapitalName)
        {

            countries = countries.Where(x => x.Capital == CapitalName).ToList();
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }
        }
    }
}

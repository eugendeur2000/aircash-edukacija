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
            //Main().ConfigureAwait(true).GetAwaiter().GetResult();
            //Console.ReadKey();
        }
        static async Task Main()
        {
            
            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://restcountries.com/v3.1/all");
            //Console.WriteLine(result);
            var Country = JsonConvert.DeserializeObject<Country>(result);
        }
        
    }
}

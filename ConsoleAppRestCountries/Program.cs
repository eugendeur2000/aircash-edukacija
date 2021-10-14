using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAppRestCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().ConfigureAwait(true).GetAwaiter().GetResult();
            Console.ReadKey();
        }
        static async Task Main()
        {
            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://restcountries.com/v3.1/all");
            Console.WriteLine(result);
        }
        
    }
}

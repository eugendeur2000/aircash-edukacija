using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleAppAppi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Main().ConfigureAwait(true).GetAwaiter().GetResult();
        }
        static async Task Main()
        {
            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://imdb-api.com/API/AdvancedSearch/k_r9c3h40j/?genres=action,adventure");
            var Netflix = JsonConvert.DeserializeObject<List<Netflix>>(result);
            //Console.WriteLine("select");
            //Console.WriteLine("1-all Movies");
            //var selectedOption = Convert.ToInt32(Console.ReadLine();

            //switch (selectedOption)
            //{
                //case 1:
                    //printAllMovies(Netflix);

                    //break;



        }
        static void printAllMovies(List<Movies> Netflix)
        {
            foreach (var Movies in Netflix)
            {
                Console.WriteLine(Movies.Title);
            }
        }
       
    }
}

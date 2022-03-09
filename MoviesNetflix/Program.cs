using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MoviesNetflix
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

            var respons = JsonConvert.DeserializeObject<Respons>(result);
            var movies = respons.results;
            var selectedOption = Convert.ToInt32(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("Enter Movie Name");
                    var title = Console.ReadLine();
                    printEveryPlot(movies, title);
                    break;


                    break;






            }

            static void printEveryPlot(List<Movie> movies, string plotTitle);
            {
                movies = movies.Where(x => x.Title == plotTtitle).ToList;
                foreach(var Movie in movies)
                {
                    Console.WriteLine(respons.results);
                }

              
                }

    }
}
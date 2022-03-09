using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace NetflixMovies
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

            var response = JsonConvert.DeserializeObject<Response>(result);
            var movies = response.results;

            Console.WriteLine("select");
            Console.WriteLine("1-all movies");
            Console.WriteLine("2-plot");
            Console.WriteLine("3-movieStars");
            Console.WriteLine("4-genres");
            var selectedOption = Convert.ToInt32(Console.ReadLine());
            switch (selectedOption)
            {
                case 1:
                    printEveryMovie(movies);

                    break;
                case 2:
                    printEveryPlot(movies);

                    break;
                case 3:
                    printAllStars(movies);

                    break;
                case 4:
                    printGenres(movies);

                    break;
            }

        }

        static void printEveryMovie(List<Movie> movies)
        {
            foreach (var response in movies)
            {
                Console.WriteLine(response.Title);
            }
        }
        static void printEveryPlot(List<Movie> movies)
        {
            foreach (var response in movies)
            {
                Console.WriteLine(response.Plot);
            }
        }
        static void printAllStars(List<Movie>movies)
        {
            foreach(var response in movies)
            {
                Console.WriteLine(response.Stars);
            }
        }
        static void printGenres(List<Movie> movies)
        {
            foreach (var response in movies)
            {
                Console.WriteLine(response.Genres);
            }
        }


    }

    
}


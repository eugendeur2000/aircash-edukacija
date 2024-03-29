﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Genres
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

            var second = JsonConvert.DeserializeObject<List<Second>>(result);
            var movies = second.results;
        }
    }
}

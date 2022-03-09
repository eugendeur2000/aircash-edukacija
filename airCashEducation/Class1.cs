using System;
using System.Collections.Generic;
using System.Text;

namespace GenresMovies
{
    class second
    {
        public string querystring { get; set; }
        public List<Movie> results { get; set; }
    }
    class Movie
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string Genres { get; set; }
        public string Plot { get; set; }
        public string Stars { get; set; }

    }
}

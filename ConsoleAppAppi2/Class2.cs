using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAppi2
{
    class Movies
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public int Description { get; set; }
        public string Genres { get; set; }
        public string Plot { get; set; }
        public string Stars { get; set; }
        public List<string> StarList { get; set; }
    }
}

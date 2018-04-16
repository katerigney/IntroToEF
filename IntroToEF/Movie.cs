using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
{
    class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public double Rating { get; set; }
    }
}

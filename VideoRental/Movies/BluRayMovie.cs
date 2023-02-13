using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    public class BluRayMovie : MoviePhisical
    {
        public BluRayMovie(string title, int number_of_copies) : base(title, number_of_copies)
        {
            Console.WriteLine("Jestem w konstruktorze BRMovie");
        }
    }
}

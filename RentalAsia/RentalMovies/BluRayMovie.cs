using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public class BluRayMovie : MoviePhisical
    {
        private readonly IMovie tylkoDoOdczytu = new BluRayMovie("cos", 2);
        public BluRayMovie(string title, int number_of_films) : base(title, number_of_films)
        {
            var x = "cos";
        }
    }
}

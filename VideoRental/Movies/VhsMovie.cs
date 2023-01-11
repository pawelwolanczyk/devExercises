using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    public class VhsMovie : MoviePhisical
    {
        public VhsMovie(string title, int number_of_films) : base(title, number_of_films)
        {

        }
    }
}

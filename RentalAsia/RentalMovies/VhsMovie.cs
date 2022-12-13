using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public class VhsMovie : MoviePhisical
    {
        public VhsMovie(string title, int number_of_films) : base(title, number_of_films)  
        {

        }
    }
}

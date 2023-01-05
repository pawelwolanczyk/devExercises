using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    internal class DvdMovie : MoviePhisical
    {
        public DvdMovie(string title, int number_of_copies) : base(title, number_of_copies)
        {

        }
    }
}

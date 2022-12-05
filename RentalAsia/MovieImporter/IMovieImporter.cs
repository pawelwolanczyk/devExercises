using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.MovieImporter
{
    internal interface IMovieImporter
    {
        bool ImportMovies();

        IList<IMovie> Movies { get; }
    }
}

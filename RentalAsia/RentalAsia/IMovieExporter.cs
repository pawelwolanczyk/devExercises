using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public interface IMovieExporter
    {
        void Export(ListMovies movies);
    }
}

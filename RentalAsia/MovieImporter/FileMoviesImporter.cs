using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.MovieImporter
{
    public class FileMoviesImporter : IMovieImporter
    {
        public IList<IMovie> Movies { get; }

        public bool ExportMovies(Rental rental)
        {
            if (rental == null)
                throw new ArgumentNullException();

            string filmy = rental.GetMoviesAsText();
            FileStream fs = File.Open("C:\\Temp2\\filmy.txt", FileMode.CreateNew);
            fs.Write(Encoding.ASCII.GetBytes(filmy),0, filmy.Length);
            fs.Close();

            return true;
        }

        public bool ImportMovies()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.Containers;
using VideoRental.Movies;

namespace VideoRental.RentalManagement
{
    public class RentalMovies : List<IMovie>
    {
        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Title == movieTitle)
                {
                    return this[i];
                }
            }

            return null;
        }

        public List<string> GetAllMovies()
        {
            List<string> allMovies = new List<string>();
            foreach (IMovie movie in this)
            {
                allMovies.Add(movie.Title);
            }

            return allMovies;
        }
    }
}

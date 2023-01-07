using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;

namespace VideoRental.RentalManagement
{
    internal class RentalMovies : List<IMovie>
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
            Logger logg = LogManager.GetCurrentClassLogger();

            List<string> allMovies = new List<string>();
            foreach (IMovie movie in this)
            {
                allMovies.Add(movie.Title);
                logg.Debug("Dodano film do listy wszytskich filmów" + movie.Title);
            }

            return allMovies;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public class Rental
    {
        private List<IMovie> _movies = new List<IMovie>();

        public void AddMovie(IMovie movie)
        {
            _movies.Add(movie);
        }

        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].GetTitle() == movieTitle)
                    return _movies[i];
            }
            return null;
        }

        public bool RemoveMovie(string movieTitle)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (movieTitle == _movies[i].GetTitle())
                {
                    _movies.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<string> GetAllMovies()
        {
            List<string> allMovies = new List<string>();

            for (int i = 0; i <= _movies.Count; i++)
            {
                 allMovies.Add(_movies[i].GetTitle());
            }
            return allMovies;
        }
    }
}

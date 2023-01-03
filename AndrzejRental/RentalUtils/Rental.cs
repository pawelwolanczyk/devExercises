using AndrzejRental.UserUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.RentalUtils
{
    internal class Rental
    {
        private List<IMovie> _movies = new List<IMovie>();
        // lista filmow poczatkowych dla uzytkownika premium
        private List<IMovie> _startingCollection = new List<IMovie>();
        
        public void AddMovie(IMovie movie)
        {
            _movies.Add(movie);
            // UserMovies.GetInstance().GetMovies().Add(movie);
        }

        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].GetTitle() == movieTitle)
                {
                    return _movies[i];
                }
            }
            return null;

        }

        public List<string> GetAllMovies()
        {
            List<string> allMovies = new List<string>();
            foreach (IMovie movie in _movies)
            {
                allMovies.Add(movie.GetTitle());
            }
            return allMovies;
        }

        public bool RemoveMovie(string movieTitle)
        {
            for (int i = 0; i < _movies.Count; i++)
            {
                if (_movies[i].GetTitle() == movieTitle)
                {
                    _movies.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // nowe metody

        public bool FillStartingCollection(string film1, string film2)
        {
            if ((StreamingMovie)(Find(film1)) == true)
            {
                _startingCollection.Add(Find(film1));
                return true;
            }
            else
            {
                return false;
            }
            // _startingCollection.Add(Find(film2));
        }

        public List<string> GetTitlesStartingList()
        {
            List<string> listaStartowaTytuly = new List<string>();
            foreach (IMovie movie in _startingCollection)
            {
                listaStartowaTytuly.Add(movie.GetTitle());
            }
            return listaStartowaTytuly;
        }

        public List<IMovie> GetStartingCollection()
        {
            return _startingCollection;
        }


    }
}

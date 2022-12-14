using RentalAsia.MovieImporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
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


        public int GetNumberOfMovies()
        {
            return _movies.Count;
        }

        public int NumberOfPhisicalMovies
        {
            get
            {
                int a = 0;

                foreach(IMovie movie in _movies)
                {
                    MoviePhisical mp = (MoviePhisical)movie;
                    if (mp != null)
                        a += mp.NumberOfCopies;
                }

                return a;
            }
        }

        public List<string> GetAllMovies()
        {
            List<string> allMovies = new List<string>();

            foreach(IMovie movie in _movies)
            {
                allMovies.Add(movie.GetTitle());
            }

            return allMovies;
        }

        public string GetMoviesAsText()
        {
            string result = String.Empty;
            List<string> filmy = GetAllMovies();
            foreach (string item in filmy)
                result += (item + "\n");

            return result;
        }

        //void Import(IMovieImporter importer)
        //{
        //    if (importer.ImportMovies())
        //        _movies.AddRange(importer.Movies);
        //    else
        //        Console.WriteLine("Import failed");
        //}
    }
}

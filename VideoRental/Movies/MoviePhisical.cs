using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    abstract public class MoviePhisical : IMovie
    {
        private static int _numberOfAllPhisicalFilms = 0;

        private string _title;
        private int _number_of_copies;

        public string Title => _title;

        public bool IsAvailable => _number_of_copies > 0;

        public MoviePhisical(MoviePhisical movie)
        {
            _title = movie.Title;
            _number_of_copies = movie._number_of_copies;
        }

        public MoviePhisical(string title, int number_of_copies)
        {
            _title = title;
            _number_of_copies = number_of_copies;
            _numberOfAllPhisicalFilms += number_of_copies;
        }

        public static int CalculateAllFilms_Static()
        {
            return _numberOfAllPhisicalFilms;
        }

        public bool Rent(DateTime Start, DateTime endTime)
        {
            if (_number_of_copies > 0)
            {
                _number_of_copies--;
                return true;
            }

            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is IMovie)
            {
                IMovie movie = (IMovie)obj;
                return this.Title.CompareTo(movie.Title);
            }
            else
                throw new InvalidDataException();
        }
    }
}

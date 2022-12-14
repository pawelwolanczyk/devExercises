using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    internal class MoviePhisical : IMovie
    {
        private static int _numberOfAllPhisicalFilms = 0;

        private string _title;
        private int _number_of_copies;

        public string Title => _title;

        public bool IsAvailable => _number_of_copies > 0;

        public MoviePhisical(string title, int number_of_copies)
        {
            _title = title;
            _number_of_copies = number_of_copies;
            _numberOfAllPhisicalFilms += number_of_copies;
        }

        internal static int CalculateAllFilms_Static()
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
    }
}

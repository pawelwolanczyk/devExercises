using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoRental.Movies
{
    abstract public class MoviePhisical : IMovie
    {
        private static int _numberOfAllPhisicalFilms = 0;
        
        private string _title;
        private int _number_of_copies;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool IsAvailable
        {
            get { return _number_of_copies > 0; }
            set { }
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
    }
}

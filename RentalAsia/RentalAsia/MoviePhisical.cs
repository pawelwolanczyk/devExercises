using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public abstract class MoviePhisical : IMovie
    {
        private string _title;
        private int _number_of_films;

        public MoviePhisical(string title, int number_of_films)
        {
            _title = title;
            _number_of_films = number_of_films;
        }

        public string GetTitle()
        {
            return _title;
        }
        public bool Rent(DateTime Start, DateTime endTime)
        {
            if (_number_of_films > 0)
            {
                _number_of_films--;
                return true;
            }
            return false;
        }

        public virtual bool IsAvailable()
        {
            if (_number_of_films > 0)
                return true;
            else return false;
        }
    }
}

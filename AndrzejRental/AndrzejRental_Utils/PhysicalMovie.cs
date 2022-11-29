using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.AndrzejRental_Utils
{
    public abstract class PhysicalMovie : IMovie
    {
        private string _title;
        private int _number_of_films;

        public PhysicalMovie(string title, int number_of_films)
        {
            _title = title;
            _number_of_films = number_of_films;
        }

        public string GetTitle()
        {
            return _title;
        }

        public bool Rent(DateTime start, DateTime endTime)
        {


        }
        public bool IsAvailable()
        {
                

        }
    }
}

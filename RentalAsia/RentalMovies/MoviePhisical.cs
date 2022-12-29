using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public abstract class MoviePhisical : IMovie
    {
        List<IUser> _users;
        private static int _numberOfAllFilms = 0;
        private string _title;
        private int _number_of_copies_film;
        private string answerRent;
        private DateTime _rentDate;
        //private string _titleVideoAttributedOfUser;

        public MoviePhisical(string title, int number_of_films)
        {
            _title = title;
            _number_of_copies_film = number_of_films;
            _numberOfAllFilms += number_of_films;
            _users = new List<IUser>();
        }

        public string GetTitle()
        {
            return _title;
        }

        public bool DoYouWantRent(DateTime start)
        {
            if (_number_of_copies_film > 0)
            {
                //Rental(start);
                return true;
            }
            Console.WriteLine("Mamy taki film, jednak na chwilę obecną nie jest on dostępny. Spróbuj jutro :) ");
            return false;
        }

        public virtual bool IsAvailable()
        {
            if (_number_of_copies_film > 0)
                return true;
            else return false;
        }

        public bool Rent(DateTime start, IUser user)
        {
            if (_number_of_copies_film > 0)
            {
                _number_of_copies_film--;
                return true;
            }
            else
                return false;
        }

        public int CalculateAllFilms()
        {
            return _numberOfAllFilms;
        }

        public static int CalculateAllFilms_Static()
        {
            return _numberOfAllFilms;
        }

        void IMovie.Rent(DateTime start, IUser user)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public int NumberOfCopies
        {
            get
            {
                return _number_of_copies_film;
            }
        }
    }
}

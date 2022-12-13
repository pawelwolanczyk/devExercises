using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public  class MoviePhisical : IMovie
    {
        private static int _numberOfAllFilms = 0;
        private string _title;
        private int _number_of_copies_film;
        private string answerRent;
        //private string _titleVideoAttributedOfUser;

        public MoviePhisical(string title, int number_of_films)
        {
            _title = title;
            _number_of_copies_film = number_of_films;
            _numberOfAllFilms += number_of_films;
        }

        public string GetTitle()
        {
            return _title;
        }

        public bool DoYouWantRent(DateTime start)
        {
            if (_number_of_copies_film > 0)
            {
                Rental(start);
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

        public void Rental(DateTime start)
        {
            DateTime daystart = start.Date;

            Console.WriteLine("Posiadamy poszukiwany przez Ciebie film.\n Czy chcesz go wypożyczyć? (tak/nie)");
            do
            {
                answerRent = Console.ReadLine();

                if (answerRent == "tak")
                {
                    _number_of_copies_film--;
                    Console.WriteLine("Wypożyczamy Pani/Panu film do " + daystart.AddDays(1) + "Oddanie filmu po terminie wiąze się z dodatkową opłatą.");
                }
                else if (answerRent == "nie")
                {
                    Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");
                }
                else if (answerRent != "tak" && answerRent != "nie")
                {
                    Console.WriteLine("Nie rozumiem odpowiedzi. Proszę odpowiedz jeszcze raz. Czy chcesz wypożyczyć wyszukiwany film? (tak/nie");
                }
            }
            while (answerRent != "tak" && answerRent != "nie");
        }

        public int CalculateAllFilms()
        {
            return _numberOfAllFilms;
        }

        public static int CalculateAllFilms_Static()
        {
            return _numberOfAllFilms;
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

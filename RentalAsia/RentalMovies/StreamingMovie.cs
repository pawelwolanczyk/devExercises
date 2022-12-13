﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
     public class StreamingMovie : IMovie
    {
        string _title;
        private string answerRent;
        public string GetTitle()
        {
            return _title;
        }
        public bool DoYouWantRent(DateTime start )
        {
            Rental(start);
            return true;
        }

        public void Rental(DateTime start)
        {
            Console.WriteLine("Posiadamy poszukiwany przez Ciebie film.\n Czy chcesz go wypożyczyć? (tak/nie)");
            do
            {
                answerRent = Console.ReadLine();

                if (answerRent == "tak")
                {
                    Console.WriteLine("Wypożyczamy Pani/Panu film do " + start.AddDays(1) + "Oddanie filmu po terminie wiąze się z dodatkową opłatą.");
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

        public virtual bool IsAvailable()
        {
            return true;
        }

        public StreamingMovie(string title)
        {
            _title = title;
        }
    }
}

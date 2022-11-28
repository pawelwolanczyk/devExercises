using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalAsia;

namespace RentalAsia
{
    public class RentalAsia
    {
        static void Main(string[] args)
        {
            Rental x = new Rental();

            PopuletMovies(x);
            Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");

            IMovie movie = x.Find(Console.ReadLine());
            if (movie != null)
            {
                if (movie.Rent(DateTime.Now, DateTime.Now.AddDays(1)))
                    Console.WriteLine("Film wypożyczam do jutra");
                else
                    Console.WriteLine("Mamy taki film, jednak na chwilę obecną nie jest on dostępny. Spróbuj jutro :) ");
            }
            else
            {
                Console.WriteLine("Niestety nie posiadamy porządanego przez państwa filmu. \n Aktualnie dysponujemy filmami:");
                List<string> filmy = x.GetAllMovies();
                foreach(string f in filmy)
                    Console.WriteLine(f);
            }
        }
        static void PopuletMovies(Rental wypozyczalnia)
        {
            wypozyczalnia.AddMovie(new BluRayMovie("Garfild", 2));
            wypozyczalnia.AddMovie(new BluRayMovie("Pamiętnik", 5));
            wypozyczalnia.AddMovie(new BluRayMovie("Need For Speed", 3));
            wypozyczalnia.AddMovie(new BluRayMovie("Skazani na Shawshank", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Za szybko za wściekle", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Kamień Filozoficzny", 5));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Komnata Tajemnic", 5));
            wypozyczalnia.AddMovie(new VhsMovie("Once Upon a Time in the West", 3));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather", 7));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather II", 5));
            wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            wypozyczalnia.AddMovie(new StreamingMovie("Intouchables"));
            wypozyczalnia.AddMovie(new StreamingMovie("Inception"));
            wypozyczalnia.AddMovie(new StreamingMovie("Green Book"));
            wypozyczalnia.AddMovie(new StreamingMovie("Zootopia"));
        }
    }
}

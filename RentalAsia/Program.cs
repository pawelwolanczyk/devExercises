using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalAsia;
using RentalAsia.MovieImporter;

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
                Console.WriteLine("Posiadamy w naszej kolekcji " + x.NumberOfMovies + " filmów");
                Console.WriteLine("Niestety nie posiadamy porządanego przez państwa filmu. \n Aktualnie dysponujemy filmami:");
                List<string> filmy = x.GetAllMovies();
                foreach(string f in filmy)
                    Console.WriteLine(f);
            }

            //x.NumberOfMovies = 1000;
            //Console.WriteLine("Mamy w kolekcji " + x.NumberOfMovies + " filmow");

            FileMoviesImporter importer = new FileMoviesImporter();
            importer.ExportMovies(x);
            //importer.Movies = new List<IMovie>();
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
            //rozwiazanie numer 1 - najpierw tworze obiekt, przechowuje w zmiennej MoviePhisical
            //nastepnie dodaje go do listy, a potem wolam na nim metode wyswietlajaca liczbe nośników:
            MoviePhisical x = new VhsMovie("12 Angry Men", 4);
            wypozyczalnia.AddMovie(x);
            x.CalculateAllFilms();
            //rozwiazanie numer 2:
            //wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            //IMovie x = wypozyczalnia.Find("12 Angry Men");
            //(x as MoviePhisical).CalculateAllFilms();
            Console.WriteLine(MoviePhisical.CalculateAllFilms_Static());
            wypozyczalnia.AddMovie(new StreamingMovie("Intouchables"));
            wypozyczalnia.AddMovie(new StreamingMovie("Inception"));
            wypozyczalnia.AddMovie(new StreamingMovie("Green Book"));
            wypozyczalnia.AddMovie(new StreamingMovie("Zootopia"));
        }
    }
}

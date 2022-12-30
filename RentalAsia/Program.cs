using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalAsia.RentalMovies;
using RentalAsia.MovieImporter;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace RentalAsia
{
    public class RentalAsia
    {
        static void Main(string[] args)
        {
            NewUser newUser = new NewUser();
            string answerNewUser;
            string title;

            Console.WriteLine("Witamy w wypożyczalni filmów! \n Jeśli chciałby Pan/Pani wypożyczyć film warunkiem koniecznym jest założenie konta" +
                "\n Czy przejść do procedury zakładania konta? (tak/nie)");
            do
            {
                answerNewUser = Console.ReadLine();
                if (answerNewUser == "tak")
                    newUser.CreateNewUser();
                else if (answerNewUser == "nie")
                {
                    Console.WriteLine("Zapraszamy, gdy zdecydouje się Pan/Pani na założenie konta. Zapewniamy, że nie spamujemy! Miłego dnia!");
                    //Jak zamknąc okno konsoli?
                }
                else
                    Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz założyć konto? (tak/nie)");
            }
            while (answerNewUser != "nie" && answerNewUser != "tak");

            Rental x = new Rental();

            RentalMovies(x);

            Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");
            title = Console.ReadLine();

            IMovie movie = x.Find(title);
            if (movie != null)
            {
                //movie.DoYouWantRent(DateTime.Now);

                //UserData attributedToUser = new UserData();
                //attributedToUser.AttributedToUser(title);
                //movie.Rental(startTime, newUser);
            }
            else
            {
                Console.WriteLine("Posiadamy w naszej kolekcji " + x.GetNumberOfMovies() + " filmów");
                Console.WriteLine("Niestety nie posiadamy porządanego przez państwa filmu. \n Aktualnie dysponujemy filmami:");
                List<string> filmy = x.GetAllMovies();
                foreach(string f in filmy)
                    Console.WriteLine(f);
            }


            //x.NumberOfMovies = 1000;
            //Console.WriteLine("Mamy w kolekcji " + x.NumberOfMovies + " filmow");

            //FileMoviesImporter importer = new FileMoviesImporter();
            //importer.ExportMovies(x);
            //importer.Movies = new List<IMovie>();
        }
        static void RentalMovies(Rental wypozyczalnia)
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

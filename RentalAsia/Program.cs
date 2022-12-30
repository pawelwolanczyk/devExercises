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
            UserData newUser = new UserData();
            string answerNewUser;
            string title;

            Rental x = new Rental();
            RentalMovies(x);
            UserList(newUser);

            Console.WriteLine("Witamy w wypożyczalni filmów! \n Jeśli chciałby Pan/Pani wypożyczyć film warunkiem koniecznym jest założenie konta" +
                "\n Czy posiadasz już u nas konto użytkownika? (tak/nie)");

            answerNewUser = Console.ReadLine();

            do
            {
                if (answerNewUser == "tak")
                {
                    //Tutaj mam wywołać logowanie do profilu użytkownika
                }
                else if (answerNewUser == "nie")
                {
                    Console.WriteLine("Czy chcesz założyć konto użytkownika i swobodnie wypożyczać filmy? (tak/nie)");
                    answerNewUser = Console.ReadLine();
                    do
                    {
                        if (answerNewUser == "tak")
                        {
                            newUser.CreateNewUser();
                        }
                        else if (answerNewUser == "nie")
                            Console.WriteLine("Zapraszamy, gdy zdecydouje się Pan/Pani na założenie konta. Zapewniamy, że nie spamujemy! Miłego dnia!");
                        else
                            Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz założyć konto? (tak/nie)");
                    }
                    while (answerNewUser != "nie" && answerNewUser != "tak");
                    }
                else
                        Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz posiadasz konto użytkownika? (tak/nie)");
                }
<<<<<<< HEAD
=======
                else
                    Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz założyć konto? (tak/nie)");
            }
>>>>>>> a2aa6afe8c976fd63db1dd5c7b5f0993c66ed99f
            while (answerNewUser != "nie" && answerNewUser != "tak");


            //Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");
            //title = Console.ReadLine();

            //IMovie movie = x.Find(title);
            //if (movie != null)
            //{
            //    movie.DoYouWantRent(DateTime.Now);

<<<<<<< HEAD
            //    UserData attributedToUser = new UserData();
            //    attributedToUser.AttributedToUser(title);
            //}
            //else
            //{
            //    Console.WriteLine("Posiadamy w naszej kolekcji " + x.GetNumberOfMovies() + " filmów");
            //    Console.WriteLine("Niestety nie posiadamy porządanego przez państwa filmu. \n Aktualnie dysponujemy filmami:");
            //    List<string> filmy = x.GetAllMovies();
            //    foreach(string f in filmy)
            //        Console.WriteLine(f);
            //}
=======
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
>>>>>>> a2aa6afe8c976fd63db1dd5c7b5f0993c66ed99f


            //x.NumberOfMovies = 1000;
            //Console.WriteLine("Mamy w kolekcji " + x.NumberOfMovies + " filmow");

            //FileMoviesImporter importer = new FileMoviesImporter();
            //importer.ExportMovies(x);
            //importer.Movies = new List<IMovie>();
        }
        static void UserList(UserData nameUser)
        {
            nameUser.AddUserToList(new UserData("Mieciu", " Mieczysław", "Kowalski", " 12.12.1956", "mieciu123@gmail.com"));
            nameUser.AddUserToList(new UserData("Maniek", " Stasiek", " Leniuch", " 22.12.1956", "stasiek123@gmail.com"));
            nameUser.AddUserToList(new UserData("foczka", " Jola", " Motyl", " 16.12.1978", "foczka123@gmail.com"));
            nameUser.AddUserToList(new UserData("kicia", " Basia", " Trump", " 12.11.1956", "basia123@gmail.com"));
            nameUser.AddUserToList(new UserData("lulu", " Stanisława", " Falalalala", "12.06.1996", "lulu123@gmail.com"));
            nameUser.AddUserToList(new UserData("gwiazdka", " Gertruda", " Mankiewicz", "12.12.1986", "gwiazdka123@gmail.com"));

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

﻿using System;
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
using RentalAsia.Menu;
using RentalAsia.UserAccount;

namespace RentalAsia
{
    public class RentalAsia
    {
        static void Main(string[] args)
        {
            AddUserToList newUser = new AddUserToList();
            string answerNewUser;
            string title;


            Rental x = new Rental();
            RentalMovies(x);
            UserList(newUser);
            //newUser.Logowanie(newUser, "AlaMaKota123");

            Console.WriteLine("Witamy w wypożyczalni filmów! \n Jeśli chciałby Pan/Pani wypożyczyć film warunkiem koniecznym jest założenie konta" +
                "\n Czy posiadasz już u nas konto użytkownika? (tak/nie)");

            answerNewUser = Console.ReadLine();

        //    do
        //    {
        //        if (answerNewUser == "tak")
        //        {
        //            //Tutaj mam wywołać logowanie do profilu użytkownika
        //        }
        //        else if (answerNewUser == "nie")
        //        {
        //            Console.WriteLine("Czy chcesz założyć konto użytkownika i swobodnie wypożyczać filmy? (tak/nie)");
        //            answerNewUser = Console.ReadLine();
        //            do
        //            {
        //                if (answerNewUser == "tak")
        //                {
        //                    newUser.CreateNewUser();
        //                }
        //                else if (answerNewUser == "nie")
        //                    Console.WriteLine("Zapraszamy, gdy zdecydouje się Pan/Pani na założenie konta. Zapewniamy, że nie spamujemy! Miłego dnia!");
        //                else
        //                    Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz założyć konto? (tak/nie)");
        //            }
        //            while (answerNewUser != "nie" && answerNewUser != "tak");
        //        }
        //        else
        //            Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz posiadasz konto użytkownika? (tak/nie)");
        //    }
        //        else
        //        Console.WriteLine("Nie rozpoznaliśmy odpowiedzi. Proszę podaj jeszcze raz odpowiedź, czy chcesz założyć konto? (tak/nie)");
        //}
        //    while (answerNewUser != "nie" && answerNewUser != "tak");



            //Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");
            //title = Console.ReadLine();

            //IMovie movie = x.Find(title);
            //if (movie != null)
            //{
            //    movie.DoYouWantRent(DateTime.Now);
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

            //IMovie movie = x.Find(title);
            //if (movie != null)
            //{
            //    //movie.DoYouWantRent(DateTime.Now);

            //    //UserData attributedToUser = new UserData();
            //    //attributedToUser.AttributedToUser(title);
            //    //movie.Rental(startTime, newUser);
            //}
            //else 
            //{
            //    Console.WriteLine("Posiadamy w naszej kolekcji " + x.GetNumberOfMovies() + " filmów");
            //    Console.WriteLine("Niestety nie posiadamy porządanego przez państwa filmu. \n Aktualnie dysponujemy filmami:");
            //    List<string> filmy = x.GetAllMovies();
            //    foreach(string f in filmy)
            //        Console.WriteLine(f);
            //}

            //x.NumberOfMovies = 1000;
            //Console.WriteLine("Mamy w kolekcji " + x.NumberOfMovies + " filmow");

            //FileMoviesImporter importer = new FileMoviesImporter();
            //importer.ExportMovies(x);
            //importer.Movies = new List<IMovie>();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrzejRental.RentalUtils;
using AndrzejRental.UserUtils;

namespace AndrzejRental
{
    public class Program
    {
        static void Main(string[] args)
        {
            //INICJACJA PROGRAMU
            Rental baseRental = new Rental();
            PopuletMovies(baseRental);

            baseRental.FillStartingCollection("Garfild", "The Godfather");

            UserRental baseUsers = new UserRental();
            PopuletUsers(baseUsers, baseRental);

            Console.WriteLine("--- Dodano " + baseUsers.GetAllUsersCount + " wszystkich bazowych uzytkownikow. Z czego " + baseUsers.GetPremiumUsersCount + " to klienci PREMIUM");

            List<string> users = baseUsers.GetUsersNames();
            Console.WriteLine("--- Lista uzytkownikow bazowych: ");
            foreach (string user in users)
            {
                Console.WriteLine("   - " + user);
            }
            Console.WriteLine();
            Console.WriteLine("--- Lista Kolekcji StartowejPremium");
            foreach (string a in baseRental.GetTitlesStartingList())
            {
                Console.WriteLine("   - " + a);
            }
            Console.WriteLine("\n...Nacisnij cokolwiek...");
            
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            //KONIEC INICJACJI
            WypozyczalniaStart(baseUsers, baseRental);

        }

        internal static void WypozyczalniaStart(UserRental baseUsers, Rental baseRental)
        {
            Console.WriteLine("Witamy w naszej wypozyczalni.\n1 - Administrator wypozyczalni \n2 - Uzytkownik");
            while (true)
            {
                string a = Console.ReadLine();
                if (a[0] == '1')
                {
                    AdminMainMenu.AdminMain();
                }
                else
                {
                    UserMainMenu.UserMain(baseUsers, baseRental);
                }
            }
        }


        static void PopuletUsers(UserRental listaUserow, Rental baseRental)
        {
            listaUserow.AddUser(new UserNormal("Maciej Zwyczajny", "haslo3", 92111212345));
            listaUserow.AddUser(new UserPremium(baseRental, "Pawel", "haslo", 12345678901));
            listaUserow.AddUser(new UserPremium(baseRental, "Andrzej Kaganek", "haslo", 85070712345));
            listaUserow.AddUser(new UserPremium(baseRental, "Jan Kowalski", "haslo1", 87020312345));
            listaUserow.AddUser(new UserPremium(baseRental, "Arnold Nowak", "haslo2", 98050312345));

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
            //x.CalculateAllFilms();
            //rozwiazanie numer 2:
            //wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            //IMovie x = wypozyczalnia.Find("12 Angry Men");
            //(x as MoviePhisical).CalculateAllFilms();
            wypozyczalnia.AddMovie(new StreamingMovie("Intouchables"));
            wypozyczalnia.AddMovie(new StreamingMovie("Inception"));
            wypozyczalnia.AddMovie(new StreamingMovie("Green Book"));
            wypozyczalnia.AddMovie(new StreamingMovie("Zootopia"));
            Console.WriteLine("Liczba kopii fizycznych filmow: " + MoviePhisical.CalculateAllFilms_Static());
        }


    }
}

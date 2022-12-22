using AndrzejRental.RentalUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.UserUtils
{
    internal static class UserMainMenu
    {
        internal static void UserMain(UserRental listaIUserow, Rental listaIMovies)
        {
            int pesel;
            string userName;
            string password;
            

            while (true)
            {
                Console.WriteLine("Dzien dobry");
                Console.WriteLine("Czy jestes naszym klientem? (t/n)");
                Console.WriteLine("x - Wyjscie");
                List<IMovie> movieList = new List<IMovie>();
                char q1 = Console.ReadLine()[0];
                if (q1 == 't') ExistingUser(listaIUserow, listaIMovies);
                else if (q1 =='x')
                {
                    Program.WypozyczalniaStart(listaIUserow, listaIMovies);
                }
                else
                {
                    Console.WriteLine("Zapraszamy do utworzenia konta uzytkownika");
                    Console.WriteLine("Wybierz konto: \n1 - Konto Standard\n2 - Konto PREMIUM (dostajesz na start 2 filmy GRATIS)");
                    char q2 = Console.ReadLine()[0];
                    Console.Write("Podaj swoja nazwe (login): ");
                    userName = Console.ReadLine();
                    Console.Write("Podaj swoje haslo (dowolny ciag znakow): ");
                    password = Console.ReadLine();
                    Console.Write("Podaj swoj PESEL (11 cyfr): ");
                    pesel = Convert.ToInt32(Console.ReadLine());
                    if (q2 == 1)
                    {
                        listaIUserow.AddUser(new UserNormal(userName, password, pesel));
                    }
                    else
                    {
                        listaIUserow.AddUser(new UserPremium(listaIMovies, userName, password, pesel));
                    }
                    Console.WriteLine("Konto zostało utworzone...Naciśnij cokolwiek");
                    Console.ReadLine();
                    Program.WypozyczalniaStart(listaIUserow, listaIMovies);
                    
                }
            }
        }

        public static void ExistingUser(UserRental listaUserow, Rental listaIMovies)
        {
            string userName;
            string password;
            IUser user;
            while (true)
            {
                Console.WriteLine("Witamy w panelu logowania");
                Console.WriteLine();
                Console.Write("Podaj swoj login: ");
                userName = Console.ReadLine();
                Console.Write("Podaj swoje haslo: ");
                password = Console.ReadLine();
                user = listaUserow.FindUser(userName);
                if (user == null)
                {
                    Console.WriteLine("Nieprawidlowy login lub nie ma takiego uzytkownika");
                    continue;
                }
                else
                {
                    if (user.GetPassword() != password)
                    {
                        Console.WriteLine("Nieprawidlowe haslo");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Panel Klienta");
                Console.WriteLine("1 - Twoje Dane\n2 - Posiadane filmy\n3 - Wypozycz film\n4 - Wyjdz");
                char q11 = Console.ReadLine()[0];
                if (q11 == '4') { break; }
                switch (q11)
                {
                    case '1':
                        if (user.PremiumStatus)
                        {
                            Console.WriteLine("Konto PREMIUM");
                        }
                        else { Console.WriteLine("Konto Standard"); }
                        Console.WriteLine("Login: " + user.GetUserName());
                        Console.WriteLine("Haslo: " + user.GetPassword());
                        Console.WriteLine("PESEL: " + user.GetPESEL() + "\nNacisnij cokolwiek");
                        Console.ReadKey();
                        continue;
                    case '2':
                        Console.WriteLine("Oto Twoja kolekcja filmow: ");
                        foreach (string s in user.GetTitlesInCollection())
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine("Nacisnij cokolwiek");
                        Console.ReadKey();
                        continue;

                    case '3':
                        Console.WriteLine("Aktualnie posiadasz następujące filmy: ");
                        if (user.GetTitlesInCollection() == null)
                        {
                            Console.WriteLine("Niestety NIE posiadasz filmów w swojej kolekcji ");
                        }
                        else
                        foreach (string m in user.GetTitlesInCollection())
                        {
                            Console.WriteLine(m);
                        }
                        while (true)
                        {
                            Console.WriteLine("Jaki film chciałbys wypozyczyc? ");
                            Console.WriteLine("Wpisz nazwę filmu lub nacisnuj - w - aby wyswietlic dostepna liste filmow");
                            string q12 = Console.ReadLine();
                            if (q12[0] == 'w')
                            {
                                foreach (string s in listaIMovies.GetAllMovies())
                                {
                                    Console.WriteLine(s);
                                }
                                continue;
                            }
                            else
                            {
                                if (user.AddToCollection(listaIMovies.Find(q12)) == true)
                                {
                                    Console.WriteLine("Pomyślnie dodano film");
                                }
                                else
                                {
                                    Console.WriteLine("Niestety nie udało sie");
                                }
                                
                            }
                            break;
                        }

                        break;
                        
                }
                
                
            }
        }










        //Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");

        //    IMovie movie = baseRental.Find(Console.ReadLine());
        //    if (movie != null)
        //    {
        //        //Console.WriteLine(
        //    }

    }
}

using AndrzejRental.RentalUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.UserUtils
{
    internal static class AdminMainMenu
    {
        public static void  AdminMain(UserRental listaIUserow, Rental listaIMovies)
        {
            string adminPassword = "admin";
            char adminChoose;
            while (true)
            {
                Console.WriteLine("PODAJ HASLO ADMINISTRATORA");
                string pass = Console.ReadLine();
                if (pass == adminPassword) { break; }
                else { continue; }
            }

            while (true)
            {
                Console.WriteLine("Witamy w menu Administratora");
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - Lista uzytkownikow");
                Console.WriteLine("2 - Kolekcja PREMIUM");
                Console.WriteLine("3 - Przeglad filmow");
                Console.WriteLine("x - Wyjscie ");
                adminChoose = Console.ReadLine()[0];
                if (adminChoose == '1')
                    {
                    AdminMenuUserList(listaIUserow);
                    continue;
                    }
                else if (adminChoose == '2')
                    {
                    AdminMenuPremiumCollection(listaIMovies);
                    continue;
                    }
                else if (adminChoose == 'x')
                {
                    Program.WypozyczalniaStart(listaIUserow, listaIMovies);
                }
                else { continue; }
            }


        }

        private static void AdminMenuPremiumCollection(Rental listaIMovies)
        {
            Console.WriteLine("--- Lista Kolekcji StartowejPremium");
            foreach (string a in listaIMovies.GetTitlesStartingList())
            {
                Console.WriteLine("   - " + a);
                Console.WriteLine("Noacisnij cokolwiek");
                Console.ReadLine();
            }
        }

        private static void AdminMenuUserList(UserRental listaIUserow)
        {
            List<string> users = listaIUserow.GetUsersNames();
            Console.WriteLine("--- Lista uzytkownikow bazowych: ");
            foreach (string user in users)
            {
                Console.WriteLine("   - " + user);
            }
            Console.WriteLine("Noacisnij cokolwiek");
            Console.ReadLine();
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.RentalManagement.RentalMenu;
using VideoRental.Users;

namespace VideoRental.RentalManagement.RentalMenu
{
    internal class ConsoleMenu : IMenu
    {
        public void InitialMenu()
        {
            Console.WriteLine("Witamy w naszej wypozyczalni.");
            Console.WriteLine("--- Posiadamy " + UserNormal.GetUsersNormalCount() + " wszystkich bazowych uzytkownikow. " + UserPremium.GetUsersPremiumCount() + " to klienci PREMIUM");
        }

        public AppUserType SelectUserType()
        {
            Console.WriteLine("Rozpocząc korzystanie z wypożyczalni: \nA - Administrator wypozyczalni \nU - Uzytkownik \nQ - Wyjście");

            while (true)
            {
                char userChoice = ' ';

                string menuItem = Console.ReadLine();
                if (!String.IsNullOrEmpty(menuItem))
                    userChoice = menuItem[0];

                switch (userChoice)
                {
                    case 'A':
                        return AppUserType.Administrator;
                    case 'U':
                        return AppUserType.User;
                    case 'Q':
                        return AppUserType.Unknown;
                    default:
                        Console.WriteLine("Nie rozpoznaję wyboru. Spróbuj ponownie.");
                        break;
                }
            }
        }

        public AdminOperation AdminMenu()
        {
            Console.WriteLine("Witamy w menu Administratora");

            while (true)
            {
                char adminChoose = ' ';
                Console.WriteLine("MENU:");
                Console.WriteLine("L - Zaloguj się do systemu");
                Console.WriteLine("U - Lista uzytkownikow");
                Console.WriteLine("P - Kolekcja PREMIUM");
                Console.WriteLine("M - Przeglad filmow");
                Console.WriteLine("Q - Wyjscie ");

                string menuItem = Console.ReadLine();
                if(!String.IsNullOrEmpty(menuItem))
                    adminChoose = menuItem[0];

                switch (adminChoose)
                {
                    case 'L':
                        return AdminOperation.Login;
                    case 'U':
                        return AdminOperation.PrintUsers;
                    case 'P':
                        return AdminOperation.PrintStartupMovies;
                    case 'M':
                        return AdminOperation.PrintAllMovies;
                    case 'Q':
                        return AdminOperation.Exit;
                    default:
                        Console.WriteLine("Nie rozpoznaję wyboru. Spróbuj ponownie.");
                        break;
                }
            }
        }

        public UserOperation UserMenu()
        {
            Console.WriteLine("Witamy w menu Uzytkownika");

            while (true)
            {
                char userChoice = ' ';

                Console.WriteLine("MENU:");
                Console.WriteLine("C - Załóż konto");
                Console.WriteLine("L - Zaloguj się do systemu");
                Console.WriteLine("D - Twoje Dane");
                Console.WriteLine("O - Posiadane filmy");
                Console.WriteLine("M - Lista dostepnych filmów");
                Console.WriteLine("R - Wypozycz film");
                Console.WriteLine("Q - Wyjscie ");

                string menuItem = Console.ReadLine();
                if (!String.IsNullOrEmpty(menuItem))
                    userChoice = menuItem[0];

                switch (userChoice)
                {
                    case 'C':
                        return UserOperation.CreateAccount;
                    case 'L':
                        return UserOperation.Login;
                    case 'D':
                        return UserOperation.PrintUserData;
                    case 'O':
                        return UserOperation.PrintRentedMovies;
                    case 'M':
                        return UserOperation.PrintAvailableMovies;
                    case 'R':
                        return UserOperation.RentMovie;
                    case 'Q':
                        return UserOperation.Exit;
                    default:
                        Console.WriteLine("Nie rozpoznaję wyboru. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}

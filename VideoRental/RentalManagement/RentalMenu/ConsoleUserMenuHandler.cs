using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.Users;

namespace VideoRental.RentalManagement.RentalMenu
{
    public class ConsoleUserMenuHandler : BaseConsoleHandler
    {
        public IUser CreateUserAccount()
        {
            IUser user = null;

            long pesel;
            string userName;
            string password;

            Console.WriteLine("Zapraszamy do utworzenia konta uzytkownika");
            Console.WriteLine("Wybierz konto: \nS - Konto Standard\nP - Konto PREMIUM (dostajesz na start 2 filmy GRATIS)");
            char accountType = Console.ReadLine()[0];
            Console.Write("Podaj swoja nazwe (login): ");
            userName = Console.ReadLine();
            Console.Write("Podaj swoje haslo (dowolny ciag znakow): ");
            password = Console.ReadLine();
            Console.Write("Podaj swoj PESEL (11 cyfr): ");
            pesel = long.Parse(Console.ReadLine());

            user = accountType == 'S' ? new UserNormal(userName, password, pesel) : accountType == 'P' ? new UserPremium(userName, password, pesel, null) : null;

            Console.WriteLine("Konto zostało utworzone...Naciśnij dowolny klawisz");
            Console.ReadKey();

            return user;
        }

        public string UserLogin()
        {
            Console.WriteLine("Witamy w panelu logowania");
            Console.WriteLine();
            Console.Write("Podaj swoj login: ");
            return Console.ReadLine();
        }

        public string Authenticate()
        {
            Console.Write("Podaj swoje haslo: ");
            return Console.ReadLine();
        }

        public void HandleIncorrectLogin()
        {
            Console.WriteLine("Nieprawidlowy login lub nie ma takiego uzytkownika");

            throw new InvalidUserCredentialsException();
        }

        public void HandleIncorrectPasword()
        {
            Console.WriteLine("Nieprawidlowe haslo");

            throw new InvalidUserCredentialsException();
        }

        public void PrintUserData(IUser user)
        {
            HandleNotLoggedUser(user);

            Console.WriteLine(user);
        }

        public void PrintRentedMovies(IUser user)
        {
            HandleNotLoggedUser(user);

            Console.WriteLine("Oto Twoja kolekcja filmow:\n");
            foreach (IMovie movie in user.GetRentedMovies())
                Console.WriteLine(movie.Title);

            Console.WriteLine("Nacisnij dowolny klawisz");
            Console.ReadKey();
        }

        public string RentMovie(IUser user)
        {
            HandleNotLoggedUser(user);
 

            Console.WriteLine("Jaki film chciałbys wypozyczyc? ");

            string movieTitle = Console.ReadLine();

            if (String.IsNullOrEmpty(movieTitle))
                Console.WriteLine("Nie podano tytułu. Wybierz właściwą opcję w menu aby wyświetlić dostępne filmy");

            return movieTitle;
        }

        public void HandleNotExistingMovie()
        {
            Console.WriteLine("Podany film nie istnieje. Wybierz właściwą opcję w menu aby wyświetlić dostępne filmy.");
        }

        public void HandleRentSuccessfull()
        {
            Console.WriteLine("Udało się wypożyczyć film");
        }

        private void HandleNotLoggedUser(IUser user)
        {
            if (user == null)
            {
                Console.WriteLine("Brak danych użytkownika. Najpierw się zaloguj");
                throw new UserNotLoggedInException();
            }
        }
    }
}

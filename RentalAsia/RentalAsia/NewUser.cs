using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public class NewUser 
    {
        private static int _numberOfAllUsers = 0;
        public NewUser()
        {
            _numberOfAllUsers++;
        }
        public void CreateNewUser()
        {
            UserData newUser = new UserData();
            Console.WriteLine("Podaj imię: ");
            newUser.UserName(Console.ReadLine());
            Console.WriteLine("Podaj nazwisko: ");
            newUser.UserSurname(Console.ReadLine());
            Console.WriteLine("Podaje datę urodzenia: ");
            newUser.DateOfBirth(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Podaj płeć (kobieta/mężczyzna): ");
            newUser.UserGender(Console.ReadLine());
            Console.WriteLine("Podaj email: ");

            while (newUser.IsEmail(newUser.UserEmail(Console.ReadLine())) == false)
            {
                continue;
            }

            Console.WriteLine("Podaj login: ");
            newUser.Login(Console.ReadLine());
            Console.WriteLine("Podaj hasło: ");
            newUser.UserPassword(Console.ReadLine());
            newUser.AddNewUser(newUser);
        }
    }
}

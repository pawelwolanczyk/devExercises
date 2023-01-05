using RentalAsia.RentalMovies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.UserAccount
{
    public class AddUserToList
    {
        UserData userData = new UserData();

        private List<IUser> _listUsers = new List<IUser>();

        public List<IUser> GetUsersList()
        {
            return _listUsers;
        }

        public void AddUser(IUser newuser)
        {
            _listUsers.Add(newuser);
        }

        public void CreateNewUser()
        {
            Console.WriteLine("Podaj imię: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Podaj nazwisko: ");
            string surname = (Console.ReadLine());
            Console.WriteLine("Podaje datę urodzenia: ");
            string dateOfBirth = (Console.ReadLine());
            Console.WriteLine("Podaj email: ");
            string email = (Console.ReadLine());
            userData.IsEmail(email);

            Console.WriteLine("Podaj login: ");
            string login = (Console.ReadLine());
            Console.WriteLine("Podaj hasło: ");
            string password = (Console.ReadLine());
            AddUser(new UserData(login, password, name, surname, dateOfBirth, email));
        }

        public IUser Logowanie(IUser login, string password)
        {
            for (int i = 0; i < _listUsers.Count; i++)
            {
                if (_listUsers[i] == login)
                {
                    if (GetUsersPassword() == password)
                    {
                        Console.WriteLine("Zalogowałeś się poprawnie");
                    }
                }
                else
                    Console.WriteLine("Niepoprawny login lub hasło");
            }
            return null;
        }
    }
}

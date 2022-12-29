using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public class UserData : IUser
    {
        private static string _userName;
        private static string _userSurname;
        private static string _dateOfBirth;
        private static string _login;
        private static string _email;
        private static string _password;
        private static int _idUser = 0;
        private static int _numberOfAllUsers = 0;// czy muszę ustawiać na zero, czy naturalnie zacznie od zera?
        private int _number_of_movies_rented_by_the_user;

        private List<IUser> _listUsers = new List<IUser>();
        public UserData()
        {

        }

        public UserData(string login, string userName, string userSurname, string dateOfBirth, string email)
        {
            _login = login;
            _userName = userName;
            _userSurname = userSurname;
            _dateOfBirth = dateOfBirth;
            _email = email;
            _idUser++; 
        }
        
        public int Id(int _idUser)
        {
            return _idUser;
        }
        public string UserName(string userName)
        {
            return _userName = userName;
        }

        public string UserSurname(string surname)
        {
            return _userSurname = surname;
        }
        public string DateOfBirth(DateTime date)
        {
            return _dateOfBirth = Convert.ToString(date);
        }

        public string UserEmail(string email)
        {
            return _email = email;
        }

        public bool IsEmail(string _email)
        {
            for (int i = 0; i < _email.Length; i++)
            {
                if (Convert.ToChar(_email[i]) == '@')
                    return true;
            }
            Console.WriteLine("Podałeś niepoprawny format maila.\n Ponów próbę.");
            return false;
        }

        public string Login(string login)
        {
            return _login = login;
        }
        
        public string ReturnLogin
        {
            get { return _login; }
        }

        public string UserPassword(string password)
        {
            return _password = password;
        }

        internal void AddUserToList(IUser newuser)
        {
            _listUsers.Add(newuser);
        }

        public void CreateNewUser()
        {
            Console.WriteLine("Podaj imię: ");
            UserName(Console.ReadLine());
            Console.WriteLine("Podaj nazwisko: ");
            UserSurname(Console.ReadLine());
            Console.WriteLine("Podaje datę urodzenia: ");
            DateOfBirth(Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Podaj email: ");

            while (IsEmail(UserEmail(Console.ReadLine())) == false)
            {
                continue;
            }

            Console.WriteLine("Podaj login: ");
            Login(Console.ReadLine());
            Console.WriteLine("Podaj hasło: ");
            UserPassword(Console.ReadLine());
            AddUserToList(new UserData(_login, _userName, _userSurname, _dateOfBirth, _email));
        }
    }
}

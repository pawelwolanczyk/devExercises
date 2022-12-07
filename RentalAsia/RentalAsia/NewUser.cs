using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public class NewUser : IUser
    {
        private static string _userName;
        private static string _userSurname;
        private static string _dateOfBirth;
        private static string _gender;
        private static string _login;
        private static string _email;
        private static string _password;


        private List<IUser> _users = new List<IUser>();

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

        public string UserGender(string gender)
        {
            return _gender = gender; 
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

        public string UserPassword(string password)
        {
            return _password = password;
        }

        public void AddNewUser(IUser UserLogin)
        {
            _users.Add(UserLogin);
        }

    }
}

using RentalAsia.UserAccount;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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
        private static int _number_Of_All_Users;// czy muszę ustawiać na zero, czy naturalnie zacznie od zera?
        
        public UserData()
        {
           
        }

        public UserData(string login,string password, string userName, string userSurname, string dateOfBirth, string email)
        {
            _login = login;
            _password = password;
            _userName = userName;
            _userSurname = userSurname;
            _dateOfBirth = dateOfBirth;
            _email = email;
            _idUser++;
            _number_Of_All_Users++;
        }

        public int GetId()
        {
            return _idUser;
        }
        public string GetUserName()
        {
            return _userName;
        }

        public string GetUserSurname()
        {
            return _userSurname;
        }
        public string GetDateOfBirth()
        {
            return _dateOfBirth;
        }

        public string GetUserEmail()
        {
            return _email;
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

        public string GetLogin()
        {
            return _login;
        }

        public string GetUserPassword()
        {
            return _password;
        }



        //public void AddUserToDictionary(IUser newuser, string password)
        //{
        //    _dictionaryUsers.Add(newuser, password);
        //}

        //public Dictionary<IUser, string> GetUserDictionary()
        //    { return _dictionaryUsers; }

       

        

        //public bool LogowanieDoKonta(string login, string password)
        //{
        //    foreach(var iteam in GetUsersList())
        //    {
        //        if (Convert.ToString(iteam) == login)
        //        {
        //            if(login == _login && password == _password)
        //            {
        //                Console.WriteLine("Zalogowałeś się poprawnie");
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Podałeś zły login lub hasło");
        //            return false;

        //        }
        //    }
        //    return false;
        //}

        //public bool Login(IUser login, string password)
        //{
        //    foreach (KeyValuePair<login1 password> in _dictionaryUsers)
        //    {

        //    }
        //    //{
        //    //    int i = 1;
        //    //    if (GetUsersPassword(login1) == password)
        //    //    {
        //    //        Console.WriteLine("Zalogowałeś się poprawnie. Zapraszamy do wypożyczania filmów.");
        //    //        return true;
        //    //    }
        //    //}
        //    return false;

        //iteruję foreachem po liście użytkowników, czy mam go na liście


    }
}

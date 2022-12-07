using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public interface IUser
    {
        string UserName(string username);

        string UserSurname(string surname);

        string DateOfBirth(DateTime date);

        string UserGender(string gender);

        string UserEmail(string email);

        bool IsEmail(string _email);

        string Login(string login);

        string UserPassword(string password);

    }
}

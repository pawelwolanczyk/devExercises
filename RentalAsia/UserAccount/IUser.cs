using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public interface IUser
    {
        string GetUserName();

        string GetUserSurname();

        string GetDateOfBirth();

        string GetUserEmail();

        bool IsEmail(string _email);

        string GetLogin();

        string GetUserPassword();

    }
}

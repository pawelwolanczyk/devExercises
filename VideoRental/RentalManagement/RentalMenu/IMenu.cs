using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.RentalManagement.RentalMenu
{
    enum AppUserType
    {
        Unknown,
        Administrator,
        User
    }

    enum RentalUserType
    {
        Unknown,
        StandardUser,
        PremiumUser
    }

    enum AdminOperation
    {
        Login,
        PrintUsers,
        PrintStartupMovies,
        PrintAllMovies,
        Exit
    }

    enum UserOperation
    {
        CreateAccount,
        Login,
        PrintAvailableMovies,
        PrintUserData,
        PrintRentedMovies,
        RentMovie,
        Exit
    }

    internal interface IMenu
    {
        void InitialMenu();
        AppUserType SelectUserType();
        AdminOperation AdminMenu();
        UserOperation UserMenu();
    }
}

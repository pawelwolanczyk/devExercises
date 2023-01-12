using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.RentalManagement.RentalMenu
{
    public enum AppUserType
    {
        Unknown,
        Administrator,
        User
    }

    public enum RentalUserType
    {
        Unknown,
        StandardUser,
        PremiumUser
    }

    public enum AdminOperation
    {
        Login,
        PrintUsers,
        PrintStartupMovies,
        PrintAllMovies,
        Exit
    }

    public enum UserOperation
    {
        CreateAccount,
        Login,
        PrintAvailableMovies,
        PrintUserData,
        PrintRentedMovies,
        RentMovie,
        Exit
    }

    public interface IMenu
    {
        void InitialMenu();
        AppUserType SelectUserType();
        AdminOperation AdminMenu();
        UserOperation UserMenu();
    }
}

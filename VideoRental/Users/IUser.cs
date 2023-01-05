using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.RentalManagement;
using VideoRental.Movies;

namespace VideoRental.Users
{
    internal interface IUser
    {
        string GetUserName();

        string GetPassword();

        long GetPESEL();

        bool PremiumStatus { get; }

        bool RentMovie(IMovie movie);

        List<IMovie> GetRentedMovies();
    }
}

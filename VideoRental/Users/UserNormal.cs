using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.RentalManagement;
using VideoRental.Movies;

namespace VideoRental.Users
{
    public class UserNormal : IUser
    {
        public List<IMovie> _ownMovies = new List<IMovie>();

        private static int _userNormalCount = 0;
        private string _password;
        private long _pesel;
        private string _userName;
        protected bool _isPremium;

        public UserNormal(string userName, string password, long pesel)
        {
            _userName = userName;
            _password = password;
            _pesel = pesel;
            _isPremium = false;
            _userNormalCount += 1;
        }

        public string GetPassword()
        {
            return _password;
        }

        public long GetPESEL()
        {
            return _pesel;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public bool RentMovie(IMovie movie)
        {
            if (movie.Rent(DateTime.Now, DateTime.Now.AddDays(1)))
            {
                _ownMovies.Add(movie);
                return true;
            }

            return false;
        }

        public List<IMovie> GetRentedMovies()
        {
            return _ownMovies;
        }

        public static int GetUsersNormalCount()
        {
            return _userNormalCount;
        }

        public override string ToString()
        {
            string userData = "\nLogin: " + GetUserName();
            userData += "\nHaslo: " + GetPassword();
            userData += "\nPESEL: " + GetPESEL();

            return userData;
        }

        public virtual bool PremiumStatus => false;
    }
}

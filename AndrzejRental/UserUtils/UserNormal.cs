using AndrzejRental.RentalUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.UserUtils
{
    internal class UserNormal : IUser
    {
        internal List<IMovie> _ownMovies = new List<IMovie>();

        private static int _userNormalCount = 0;
        public string _password;
        public float _pesel;
        public string _userName;
        internal bool _isPremium;

        public UserNormal(string userName, string password, float pesel)
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

        public float GetPESEL()
        {
            return _pesel;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public bool AddToCollection(IMovie movie)
        {
            if (movie.Rent(DateTime.Now, DateTime.Now.AddDays(1)))
            {
                _ownMovies.Add(movie);
                return true;
            }
            else
                return false;
        }

        public List<IMovie> GetCollection()
        {
            return _ownMovies;
        }

        public List<string> GetTitlesInCollection()
        {
            List<string> _TitlesInCollection = new List<string>();
            foreach (IMovie movie in _ownMovies)
            {
                _TitlesInCollection.Add(movie.GetTitle());
            }
            return _TitlesInCollection;
        }

        public static int GetUsersNormalCount()
        {
            return _userNormalCount;
        }

        public virtual bool PremiumStatus => false;
    }
}

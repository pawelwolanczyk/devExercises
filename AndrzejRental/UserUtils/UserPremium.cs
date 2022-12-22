using AndrzejRental.RentalUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.UserUtils
{
    internal class UserPremium : UserNormal, IUser
    {
        private static int _userPremiumCount = 0;
        
        public UserPremium(Rental x, string userName, string password, float pesel) : base(userName, password, pesel)
        {
            _isPremium = true;

            _userPremiumCount += 1;

            _ownMovies.AddRange(x.GetStartingCollection());
        }

        public static int GetUsersPremiumCount()
        {
            return _userPremiumCount;
        }

        public override bool PremiumStatus => true;
    }
}

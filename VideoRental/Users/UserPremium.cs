using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.RentalManagement;
using VideoRental.Users;

namespace VideoRental.Users
{
    public class UserPremium : UserNormal
    {
        private static int _userPremiumCount = 0;
        
        public UserPremium(string userName, string password, long pesel, List<IMovie> startupCollection) : base(userName, password, pesel)
        {
            _isPremium = true;
            _userPremiumCount += 1;
            ProcessStartupCollection(startupCollection);
        }

        public void ProcessStartupCollection(List<IMovie> startupCollection)
        {
            if (startupCollection == null)
                return;

            foreach (IMovie startupMovie in startupCollection)
                RentMovie(startupMovie);
        }

        public static int GetUsersPremiumCount()
        {
            return _userPremiumCount;
        }

        public override string ToString()
        {
            string userData = "Konto PREMIUM";

            return userData + base.ToString();
        }

        public override bool PremiumStatus => true;
    }
}

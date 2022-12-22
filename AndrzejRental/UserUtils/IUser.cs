using AndrzejRental.RentalUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.UserUtils
{
    internal interface IUser
    {
    
        string GetUserName();

        string GetPassword();

        float GetPESEL();

        bool PremiumStatus { get; }

        bool AddToCollection(IMovie movie);

        List<IMovie> GetCollection();

        List<string> GetTitlesInCollection();

    }
}

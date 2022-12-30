using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia.RentalMovies
{
    public interface IMovie // : ISerializable
    {
        string GetTitle();
        bool IsAvailable();
<<<<<<< HEAD
        bool Rental(DateTime start, DateTime end);
=======

        void Rent(DateTime start, IUser user);

        List<IUser> GetUsers();
>>>>>>> a2aa6afe8c976fd63db1dd5c7b5f0993c66ed99f
    }
}

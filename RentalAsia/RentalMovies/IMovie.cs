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
        bool Rental(DateTime start, DateTime end);
    }
}

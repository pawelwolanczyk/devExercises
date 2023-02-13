using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    public interface IMovie : IComparable
    {
        string Title { get; }

        bool IsAvailable { get; }

        bool Rent(DateTime Start, DateTime endTime);
    }
}

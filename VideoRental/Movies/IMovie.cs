using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    internal interface IMovie
    {
        string Title { get; }

        bool IsAvailable { get; }

        bool Rent(DateTime Start, DateTime endTime);
    }
}

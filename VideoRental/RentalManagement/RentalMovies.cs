using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.Containers;
using VideoRental.Movies;

namespace VideoRental.RentalManagement
{
    public class RentalMovies : SortedList<IMovie>
    {
        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Title == movieTitle)
                {
                    return this[i];
                }
            }

            return null;
        }
    }
}

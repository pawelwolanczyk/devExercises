using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;

namespace ExtensionsAndPartial.Extensions
{
    public static class VhsRewindExtension
    {
        public static bool Rewind(this VhsMovie vhsMovie)
        {
            return true;
        }

        public static void AlaMaKota(this IMovie movie)
        {
            Console.WriteLine("Rozszerzenie IMovie");
        }

        public static int CompareTo(this MoviePhisical movie, int obj)
        {
            return 0;
        }
    }
}

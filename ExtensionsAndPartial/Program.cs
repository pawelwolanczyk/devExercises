using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using ExtensionsAndPartial.Extensions;
using ExtensionsAndPartial.PartialClasses;

namespace ExtensionsAndPartial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VhsMovie vhsMovie = new VhsMovie("Krzyżacy", 2);
            vhsMovie.Rewind();
            vhsMovie.AlaMaKota();
            vhsMovie.CompareTo(1);  //in this case original (class) implementation will be executed (not extension method)

            PartialClass pC = new PartialClass();
            pC.DoSth();
            pC.DoSthMore();
        }
    }
}

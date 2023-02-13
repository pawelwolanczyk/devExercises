using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą dla której chcesz obliczyć silnię: ");
            long i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Silnia(i));
            Console.ReadKey();
        }

        static long Silnia(long j)
        {
            if (j == 1)
            {
                return 1;
            }
            else
            {
                return j * Silnia(j - 1);
            }
        }
    }
}
//static long Silnia(long i)
//{
//    long wynikk = 1;
//    while (i > 0)
//    {
//        wynikk *= i;
//        i--;
//    }
//    return wynikk;
//}
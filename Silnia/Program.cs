using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    public class Test : IDisposable
    {
        private string _name;

        public Test(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    
        public void Dispose()
        {
            Console.WriteLine("Test disposing");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using(Test test = new Test("Ala"))
            {
                Console.WriteLine(test.Name);
                Console.WriteLine("Podaj liczbę całkowitą dla której chcesz obliczyć silnię: ");
                long i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Silnia(i));
                Console.ReadKey();
            }
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
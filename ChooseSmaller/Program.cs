using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseSmaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string lettera, letterb;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            lettera = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę: ");
            letterb = Console.ReadLine();

            a = int.Parse(lettera);
            b = int.Parse(letterb);

            if (a < b)
            {
                Console.WriteLine("Mniejsze jest " + a);
            }
            else if (b < a)
            {
                Console.WriteLine("Mniejsze jest " + b);
            }
            else
            {
                Console.WriteLine("Liczby są równe");
            }
        }
    }
}

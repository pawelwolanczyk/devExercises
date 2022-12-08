using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo obiekt = new Foo(23);
            Bar obiektBar = new Bar();
            FooBar foobar = new FooBar();

            Foo fooObiekt2 = new Foo(2);
            fooObiekt2.PrintMe();
            Bar barObject1 = new Bar();
            barObject1.PrintMe();
            Bar barObject3 = new Bar(3);
            barObject3.PrintMe();

            try
            {
                funkcja(0);
                funkcja(2);
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine(x.Message);
                Console.WriteLine("Nastapil wyjatek dzielenia przez cos");
            }
            catch(ArgumentOutOfRangeException x)
            {
                Console.WriteLine("Nastapil wyjatek dostepu do nieistniejacego elementu listy");
            }
            catch (AlaMaKotaException x)
            {
                Console.WriteLine(x.Message);
                Console.WriteLine("Ala ma kota!");
            }
            catch (Exception x)
            {
                Console.WriteLine("Nastapil nieznany wyjatek");
            }

            Console.WriteLine("Jestesmy tutaj");
        }

        public static void funkcja(int a)
        {
            char x = Console.ReadLine()[0];
            if (x == 'a')
                Console.WriteLine("Result= " + (2 / a));
            else if (x == 'b')
            {
                List<char> list = new List<char>();
                list[0].ToString();
            }
            else if (x == 'c')
            {
                throw new AlaMaKotaException();
            }
            else if (x == 'd')
            {
                throw new Exception();
            }
            else if (x == 'e')
            {
                if (a == 2)
                    throw new DivideByTwoException();
                Console.WriteLine("Result= " + (2 / a));
            }
        }
    }
}

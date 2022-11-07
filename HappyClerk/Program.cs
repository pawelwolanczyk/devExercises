using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HappyClerk
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Dzień dobry. Polecam batoniki.");
        Console.Write("Pański rachunek wynosi (podaj kwotę): ");
        bool badNomi = false;
        decimal bill = decimal.Parse(Console.ReadLine());
        NomiInput:
            Console.WriteLine("Podaj nominał jakim zapłacisz (10, 20, 50, 100, 200,500: ");
            int[] banknote = { 10, 20, 50, 100, 200, 500 };
            decimal nomi = decimal.Parse(Console.ReadLine());

            //for (int i = 0; i < banknote.Length; i++)
            //{
            //    if (nomi == banknote[i])
            //    {
            //        check = true;
            //    }
            //}

            

            foreach (int b in banknote)
            {
                if (b == nomi)
                {
                    badNomi = true;
                }
            }
            if (!badNomi)
            {
                Console.WriteLine("Nie ma takiego nominału, spróbuj podać inny");
                goto NomiInput;
            }

            
        decimal rest = nomi - bill, z5, z2, z1, g50, g20, g10, g5,g2,g1;
        Console.WriteLine(rest);
            z5 = (rest - (rest % 5)) / 5;
            rest = rest - (z5 * 5);
            Console.WriteLine(rest);
            z2 = (rest - (rest % 2)) / 2;
            rest = rest - (z2 * 2);
            Console.WriteLine(rest);
            z1 = (rest - (rest % 1)) / 1;
            rest = rest - (z1 * 1);
            rest = rest * 100;
            Console.WriteLine(rest);
            g50 = (rest - (rest % 50)) / 50;
            rest = rest - (g50 * 50);
            Console.WriteLine(rest);
            g20 = (rest - (rest % 20)) / 20;
            rest = rest - (g20 * 20);
            Console.WriteLine(rest);
            g10 = (rest - (rest % 10)) / 10;
            rest = rest - (g10 * 10);
            Console.WriteLine(rest);
            g5 = (rest - (rest % 5)) / 5;
            rest = rest - (g5 * 5);
            Console.WriteLine(rest);
            g2 = (rest - (rest % 2)) / 2;
            rest = rest - (g2 * 2);
            Console.WriteLine(rest);
            if (rest == 1) 
                g1 = 1;
            else
                g1 = 0;
            

            int z500, z200, z100, z50, z20, z10;



        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("5zł - " + z5 + "szt.");
        Console.WriteLine("2zł - " + z2 + "szt.");
        Console.WriteLine("1zł - " + z1 + "szt.");
        Console.WriteLine("50gr - " + g50 + "szt.");
        Console.WriteLine("20gr - " + g20 + "szt.");
        Console.WriteLine("10gr - " + g10 + "szt.");
        Console.WriteLine("5gr - " + g5 + "szt.");
        Console.WriteLine("2gr - " + g2 + "szt.");
        Console.WriteLine("1gr - " + g1 + "szt.");


            //static void moneta(float monet, float restFun, );
            //    {
            //            monet = (restFun - (restFun % 5)) / 5;


            //    }



            Console.ReadKey();



        }
    }    
}

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
        float bill = float.Parse(Console.ReadLine());
        NomiInput:
            Console.WriteLine("Podaj nominał jakim zapłacisz (10, 20, 50, 100, 200,500: ");
            int[] banknote = { 10, 20, 50, 100, 200, 500 };
            float nomi = float.Parse(Console.ReadLine());

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

            
        float rest = nomi - bill, z5, z2, z1, g50, g20, g10, g5;
        Console.WriteLine(rest);
            z5 = (rest - (rest % 5)) / 5;
            Console.WriteLine("5 x " + z5);


            int z500, z200, z100, z50, z20, z10;


        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("5zł - " + z5 + "szt.");
        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("2zł - " + z5 + "szt.");
        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("1zł - " + z5 + "szt.");
        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("50gr - " + z5 + "szt.");
        Console.WriteLine("Wydaję resztę: ");
        Console.WriteLine("20gr - " + z5 + "szt.");



    static void moneta(float monet, float restFun, );
        {
                monet = (restFun - (restFun % 5)) / 5;


        }



        Console.ReadKey();



        }
    }    
}

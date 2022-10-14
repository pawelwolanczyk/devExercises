using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                Console.WriteLine("zly banknot");
            }
            




            Console.WriteLine("Wydaję resztę: ");

            Console.ReadKey();


        }
    }    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double number1;
            bool resParse1, resParse2;
            resParse1 = double.TryParse(Console.ReadLine(), out number1);
            if (resParse1 == true)
            {
                double number2;
                double wynik = number1;
                string next;
                do
                {
                    Console.WriteLine("Podaj kolejną liczbę: ");
                    next = Console.ReadLine();
                    resParse2 = double.TryParse(next, out number2);
                    wynik += number2;
                }
                while (resParse2 == true);
                if (next == "q")
                {
                    Console.WriteLine(" Suma: " + wynik);
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("Nie rozumiem polecenia!");
            }
            else
                Console.WriteLine("Nie rozumiem polecenia!");
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Podaj pierwszą liczbę: ");
        //    double number1;
        //    bool resParse1;
        //    resParse1 = double.TryParse(Console.ReadLine(), out number1);
        //    if (resParse1 == true)
        //    {
        //        List<double> list = new List<double>();
        //        double numbers;
        //        for (int i = 0; i >= list.Count; i++)
        //        {
        //            Console.WriteLine("Podaj kolejną liczbę: ");
        //            string s = Console.ReadLine();
        //            bool resParse2;
        //            resParse2 = double.TryParse(s, out numbers);
        //            if (resParse2 == true)
        //            {
        //                list.Add(numbers);
        //            }
        //            else if (s == "q")
        //            {
        //                double suma = number1;
        //                for (int j = 0; j < list.Count; j++)
        //                {
        //                    suma += list[j];
        //                }
        //                Console.WriteLine("Suma: " + suma);
        //                Console.ReadKey();
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Nie rozumiem polecenia!");
        //                break;
        //            }
        //        }
        //    }
        //    else
        //        Console.WriteLine("Nie rozumiem polecenia!");
        //}
    }
}

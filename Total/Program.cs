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
            bool resParse1;
            resParse1 = double.TryParse(Console.ReadLine(), out number1);            
            if (resParse1 == true)
            {
                List<double> list = new List<double>();
                double numbers;
                for (int i = 0; i >= list.Count; i++)
                {
                    Console.WriteLine("Podaj kolejną liczbę: ");
                    string s = Console.ReadLine();
                    bool resParse2;
                    resParse2 = double.TryParse(s, out numbers);
                    if (resParse2 == true)
                    {
                        list.Add(numbers);
                    }
                    else if (s == "q")
                    {
                        double suma = number1;
                        for (int j = 0; j < list.Count; j++)
                        {
                            suma += list[j];
                        }
                        Console.WriteLine("Suma: " + suma);
                        //break;
                    }
                    else
                    {
                        Console.WriteLine("Nie rozumiem polecenia!");
                        break;
                    }
                }
            }
            else
            Console.WriteLine("Nie rozumiem polecenia!");
        }
    }
}

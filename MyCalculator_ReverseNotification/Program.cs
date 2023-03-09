using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator_ReverseNotification
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>();
            char znak;
            double? wynik;
            foreach (string operend in args)
            {
                if (double.TryParse(operend, out double number))
                    stack.Push(number);
                else if (char.TryParse(operend, out znak))
                {
                    char operation = znak;
                    double n1 = stack.Pop();
                    double n2 = stack.Pop();

                    Operation operation2 = new Operation();
                    wynik = operation2.Operations(n1, n2, znak);
                    if(wynik == null)
                    {
                        Console.WriteLine("Podałeś zły znak operacji!");
                        break;
                    }
                    else
                        stack.Push((double)wynik);
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedrekCalcONP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kalkulator ONP: 
            // Działa tylko na INTACH oraz obsługuje operatory + - x /
            List <int> IntStack = new List<int> ();
            List <int> Output = new List<int>();
            int number;

            foreach (string arg in args)
            {
                if (int.TryParse(arg, out number))
                {
                    IntStack.Add (number);
                }
                else
                {
                    Operation(Convert.ToChar(arg), IntStack);
                }
                
            }

            foreach (int a in IntStack)
            {
                Console.WriteLine(a);
            }
            
            Console.ReadLine();
        }

        public static void Operation(char operat, List<int> IntStack)
        {
            int a = IntStack[IntStack.Count() - 2]; 
            int b = IntStack[IntStack.Count() - 1];
            int c;
            switch (operat)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case 'x':
                    c = a * b;
                    break;
                case '/':
                    c = a/b;
                    break;
                default:
                    c = 0;
                    break;
            }

            IntStack[IntStack.Count() - 2] = c;
            IntStack.RemoveAt(IntStack.Count() - 1);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functios
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Jak masz na imię?");
             string name = Console.ReadLine();
             Console.WriteLine("Wybierz znak: !@#$%^&*)");
             char e = Convert.ToChar(Console.ReadLine());

            if (e == '!' || e == '@' || e == '#' || e == '$' || e == '%' || e == '^' || e == '&' || e == '*' || e == ')')
            {
                Console.WriteLine("Teraz podaj podstawę trójkąta (liczba całkowita, nieparzysta):");
                int p = Convert.ToInt32(Console.ReadLine());
                if (p % 2 != 0)
                {
                    
                    Console.WriteLine(name + " - oto Twoje drzewko");
                   Tree(p, e);
                }
                else
                {
                    Console.WriteLine(name + " oszukujesz, zamykam się i nie gadam z Tobą!");
                }
            }
            else
            {
                Console.WriteLine(name + " oszukujesz, zamykam się i nie gadam z Tobą!");
            }
            void Tree(int p, char f)
            {
                string str = "";
                int high = ((p + 1) / 2);

                for (int i = 0; i < high; i++)
                {
                    int spacja = high - i;

                    for (int j = 0; j < spacja; j++)
                    {
                        str += " ";
                    }
                    for (int k = 0; k < (2 * i) + 1; k++)
                    {
                        str += f;
                    }
                    str += "\n";
                }
                Console.WriteLine(str);
                Console.ReadKey();
            }
        }

    }
    

}

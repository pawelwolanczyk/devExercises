using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.PabloTree
{
    public class TreePabloUseClass
    {
        private static string name;
        private char e;

        public TreePabloUseClass()
        {

        }
        public string NameProperty
        {
            get { return name; }
            set { name = value; }
        }
        public char EProperty
        {
            get { return e; }
            set { e = value; }
        }
        public void PrintName()
        {
            Console.WriteLine("Jak masz na imię? ");
        }

        public static void PrintCommunication()
        {
            Console.WriteLine( name + " oszukujesz, zamykam się i nie gadam z Tobą!");
            Console.ReadKey();
        }
        public void LoopMethod()
        {
            if (e == '!' || e == '@' || e == '#' || e == '$' || e == '%' || e == '^' || e == '&' || e == '*' || e == ')')
            {
                Console.WriteLine("Teraz podaj podstawę trójkąta (liczba całkowita, nieparzysta):");
                int p = Convert.ToInt32(Console.ReadLine());
                if (p % 2 != 0)
                {
                    string str = "";
                    Console.WriteLine(name + " - oto Twoje drzewko");

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
                            str += e;
                        }
                        str += "\n";
                    }
                    Console.WriteLine(str);
                    Console.ReadKey();
                }
                else
                    TreePabloUseClass.PrintCommunication();
                Console.ReadKey();
            }
            else
                TreePabloUseClass.PrintCommunication();
            Console.ReadKey();
        }
    }
}

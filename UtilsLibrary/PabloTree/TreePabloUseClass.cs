using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.PabloTree
{
    public class TreePabloUseClass
    {
        private static string _name;
        private char _sign;

        public TreePabloUseClass()
        {

        }

        public string PersonName
        {
            get { return _name; }
            set { _name = value; }
        }

        public char Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }
        public void ProcesName()
        {
            Console.WriteLine("Jak masz na imię? ");
            _name = Console.ReadLine();
        }
        
        public static void PrintCommunication()
        {
            Console.WriteLine( _name + " oszukujesz, zamykam się i nie gadam z Tobą!");
            Console.ReadKey();
        }

        public bool ProcessSign(char _sign)
        {
            if (_sign == '!' || _sign == '@' || _sign == '#' || _sign == '$' || _sign == '%' || _sign == '^' || _sign == '&' || _sign == '*' || _sign == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayTree()
        { 
            Console.WriteLine("Teraz podaj podstawę trójkąta (liczba całkowita, nieparzysta):");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p % 2 != 0)
            {
               string str = "";
               Console.WriteLine(_name + " - oto Twoje drzewko");
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
                       str += _sign;
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
    }
}

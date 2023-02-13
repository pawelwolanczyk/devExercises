using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.Containers;

namespace Sorter_with_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Co chcesz sortowac ([i]nt, [s]tring, [f]loat");
            char typ = Console.ReadLine()[0];
            if (typ == 'i')
                IntsSorter();
            else if (typ == 's')
                StringsSorter();
            else if (typ == 'f')
                FloatsSorter();
        }

        private static void StringsSorter()
        {
            SortedList<string> lista = new SortedList<string>();
            string userValue;

            do
            {
                Console.WriteLine("Podaj string lub x aby zakończyć");
                userValue = Console.ReadLine();
                lista.Add(userValue);
            }
            while (userValue != "x");

            Console.WriteLine(lista);
        }

        private static void FloatsSorter()
        {
            SortedList<float> lista = new SortedList<float>();
            string userValue;
            float intValue;

            do
            {
                Console.WriteLine("Podaj liczbę całkowitą lub x aby zakończyć");
                userValue = Console.ReadLine();
                if (float.TryParse(userValue, out intValue))
                    lista.Add(intValue);
            }
            while (userValue != "x");

            Console.WriteLine(lista);
        }

        private static void IntsSorter()
        {
            SortedList<int> lista = new SortedList<int>();
            string userValue;
            int intValue;

            do
            {
                Console.WriteLine("Podaj liczbę całkowitą lub x aby zakończyć");
                userValue = Console.ReadLine();
                if (int.TryParse(userValue, out intValue))
                    lista.Add(intValue);
            }
            while (userValue != "x");

            Console.WriteLine(lista);
        }
    }
}

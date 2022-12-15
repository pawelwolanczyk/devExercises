using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.Containers;

namespace Sorter_with_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedIntList lista = new SortedIntList();
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

            lista.SerializeToXml();
            //ListIntPrinter.StaticPrint(lista);
            //ListIntPrinter x = new ListIntPrinter();
            //x.ObjectPrint(lista);
        }
    }
}

using NLog;
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
        static readonly string loggerName = "Sorter_with_list_logger";

        static void Main(string[] args)
        {
            SortedIntList lista = new SortedIntList();
            string userValue;
            int intValue;

            do
            {
                LogManager.GetLogger(loggerName).Debug("Asking for integer");
                Console.WriteLine("Podaj liczbę całkowitą lub x aby zakończyć");
                userValue = Console.ReadLine();
                if (int.TryParse(userValue, out intValue))
                    lista.Add(intValue);
            }
            while (userValue != "x");

            Console.WriteLine(lista);
            ListIntPrinter.StaticPrint(lista);
            ListIntPrinter x = new ListIntPrinter();
            LogManager.GetLogger(loggerName).Debug("Printing list");
            x.ObjectPrint(lista);
        }
    }
}

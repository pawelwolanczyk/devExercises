using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Containers
{
    public class ListPrinter<T> where T : IComparable
    {
        public static void StaticPrint(SortedList<T> list)
        {
            string result = String.Empty;
            ListItem<T> element = list.GetBegin();

            while (element != null)
            {
                result += element.GetValue();
                if (element._next != null)
                    result += "\n";
                element = element._next;
            }

            Console.Write(result);
        }

        public void ObjectPrint(SortedList<T> list)
        {
            string result = String.Empty;
            ListItem<T> element = list.GetBegin();

            while (element != null)
            {
                result += element.GetValue();
                if (element._next != null)
                    result += "\n";
                element = element._next;
            }

            Console.Write(result);
        }
    }
}

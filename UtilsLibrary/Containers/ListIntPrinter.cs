using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Containers
{
    public class ListIntPrinter
    {
        public static void StaticPrint(SortedIntList list)
        {
            UtilsLogger.GetLogger().Debug("Print list");
            string result = String.Empty;
            ListItem element = list.GetBegin();

            while (element != null)
            {
                result += element.GetValue();
                if (element._next != null)
                    result += "\n";
                element = element._next;
            }

            Console.Write(result);
        }

        public void ObjectPrint(SortedIntList list)
        {
            string result = String.Empty;
            ListItem element = list.GetBegin();

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

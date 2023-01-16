using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UtilsLibrary.Containers
{
    public class SortedIntList
    {
        ListItem _begin;

        public SortedIntList()
        {
            UtilsLogger.GetLogger().Debug("List creating");
            _begin = null;
        }

        public void Add(int x)
        {
            UtilsLogger.GetLogger().Debug("Adding new item to list");

            if (_begin == null)
            {
                _begin = new ListItem(x);
                return;
            }

            ListItem element = _begin;
            ListItem previous = null;

            while (element != null)
            {
                if (element.GetValue() < x)
                {
                    if (element._next == null)
                    {
                        element._next = new ListItem(x);
                        break;
                    }
                    else
                    {
                        previous = element;
                        element = element._next;
                    }
                }
                else
                {
                    ListItem c = new ListItem(x);
                    c._next = element;
                    if (previous != null)
                        previous._next = c;
                    else
                        _begin = c;

                    break;
                }
            }
        }

        public override string ToString()
        {
            string result = String.Empty;
            ListItem element = _begin;

            while (element != null)
            {
                result += element.GetValue();
                if (element._next != null)
                    result += ", ";
                element = element._next;
            }

            return result;
        }

        internal ListItem GetBegin()
        {
            return _begin;
        }
    }
}

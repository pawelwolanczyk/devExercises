using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UtilsLibrary.Containers
{
    public class SortedList<T> where T : IComparable
    {
        ListItem<T> _begin;
        int _count;

        public SortedList()
        {
            _count = 0;
            _begin = null;
        }

        public void Add(T x)
        {
            _count++;
            if(_begin == null)
            {
                _begin = new ListItem<T>(x);
                return;
            }

            ListItem<T> element = _begin;
            ListItem<T> previous = null;

            while (element != null)
            {
                if (element.GetValue().CompareTo(x) < 0)
                {
                    if (element._next == null)
                    {
                        element._next = new ListItem<T>(x);
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
                    ListItem<T> c = new ListItem<T>(x);
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
            ListItem<T> element = _begin;

            while (element != null)
            {
                result += element.GetValue();
                if (element._next != null)
                    result += "\n";
                element = element._next;
            }

            return result;
        }

        internal ListItem<T> GetBegin()
        {
            return _begin;
        }

        public int Count => _count;
    }
}

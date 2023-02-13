using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Containers
{
    public class ListItem<T> : Object
    {
        private T _value;
        public ListItem<T> _next;

        public ListItem(T a)
        {
            _value = a;
            _next = null;
        }

        public T GetValue()
        {
            return _value;
        }
    }
}

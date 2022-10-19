using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Containers
{
    internal class ListItem
    {
        private int _value;
        public ListItem _next;

        public ListItem(int a)
        {
            _value = a;
            _next = null;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}

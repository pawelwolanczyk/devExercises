using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Containers
{
    public class ListItem : Object
    {
        private int _value;
        public ListItem _next;

        public ListItem()
        {
            _next = null;
        }

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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace UtilsLibrary.Containers
{
    [XmlRootAttribute("SortedIntList", Namespace = "http://www.devExcercises.com",
IsNullable = false)]
    public class SortedIntList
    {
        ListItem _begin;

        public SortedIntList()
        {
            _begin = null;
        }

        public void Add(int x)
        {
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

        public bool SerializeToXml()
        {
            FileStream fs = new FileStream("C:\\temp\\listaint.xml", FileMode.OpenOrCreate);

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SortedIntList));
                xmlSerializer.Serialize(fs, this);
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception thrown: " + x.Message);
                return false;
            }

            return true;
        }

        [XmlArray("Items")]
        public int[] OrderedItems
        {
            get
            {
                List<int> ints = new List<int>();
                ListItem element = _begin;

                while (element != null)
                {
                    ints.Add(element.GetValue());
                    element = element._next;
                }

                return ints.ToArray();
            }
            set { }
        }

        [XmlArray("FakeItems")]
        public string[] FakeItems
        {
            get
            {
                return new string[] { "ala", "ma", "kota" };
            }
            set { }
        }
    }
}

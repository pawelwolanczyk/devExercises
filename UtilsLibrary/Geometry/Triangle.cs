using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public class TriangleEquailteral : Shape
    {
        private int _podstawa;
        private int _wysokosc;

        public void Podstawa(int a)
        {
            _podstawa = a;
        }

        public void Wysokosc(int b)
        {
            _wysokosc = b;
        }

        public override double Area()
        {
            return _podstawa * _wysokosc * 0.5;
        }

        public override double Perimeter()
        {
            return 3 * _podstawa; 
        }

        public override string ToString()
        {
            return "Jestem trójkątem równobocznym";
        }
    }
}

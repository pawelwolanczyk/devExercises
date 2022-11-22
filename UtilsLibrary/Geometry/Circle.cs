using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public class Circle : Shape
    {
        private int _radius;
        
        public Circle(int radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 3.14 * _radius * _radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * _radius;
        }
    }
}

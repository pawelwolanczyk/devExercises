using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public class Rectangle : Shape
    {
        private int x;
        private int y;

        public Rectangle()
        {
            Console.WriteLine("Inside constructor without parameters");
        }

        public Rectangle(int a, int b) : this()
        {
            x = a;
            y = b;
            Console.WriteLine("Inside constructor with two ints as parameters");
        }

        public override string ToString()
        {
            return "Jestem prostokątem";
        }

        public override double Area()
        {
            return x * y;
        }

        public override double Perimeter()
        {
            return 2 * x + 2 * y;
        }
    }
}

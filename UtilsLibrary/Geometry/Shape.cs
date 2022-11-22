using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public abstract class Shape : IShape
    {
        public abstract double Area();

        public abstract double Perimeter();

        public virtual void PrintObject()
        {
            Console.WriteLine(this);
            Console.WriteLine("Powierzchnia obiektu: " + Area());
            Console.WriteLine("Obwód obiektu: " + Perimeter());
        }
    }
}

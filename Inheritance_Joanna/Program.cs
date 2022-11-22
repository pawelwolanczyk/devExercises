using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.Inheritance_Car;

namespace Inheritance_Joanna
{
     class Program
    {
        static void Main(string[] args)
        {
            {
                Car x = null;
                ArrayList cars = new ArrayList();
                cars.Add(new Skoda());
                cars.Add(new Mazda());

                foreach(object values in cars )
                {
                    x.PrintObject();
                }
            }
        }
    }
}

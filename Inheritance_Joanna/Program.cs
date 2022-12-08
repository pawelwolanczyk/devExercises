using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance_Joanna;

namespace Inheritance_Joanna
{
     class Program
    {
        static void Main(string[]args)
        {
            {
                Car x;
                ArrayList cars = new ArrayList();
                cars.Add(new Skoda());
                cars.Add(new Mazda());

                foreach(object obj in cars )
                {
                    x = (Car)obj;
                    x.PrintObject();
                }
                Console.ReadKey();
            }
        }
    }
}

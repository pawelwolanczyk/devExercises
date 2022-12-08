using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Joanna
{
    public class Mazda : Car
    {
        public override string ColorCar()
        {
            return "Czerowny";
        }

        public override string NameCar()
        {
            return "Mazda 3";
        }

        public override double EngineCapacity()
        {
            return 2.5;
        }

    }
}

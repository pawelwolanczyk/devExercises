using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Inheritance_Car
{
    public class Skoda : Car
    {
        public override string ColorCar()
        {
            return "Zielony";
        }

        public override string NameCar()
        {
            return "Roomster";
        }

        public override double EngineCapacity()
        {
            return 1.6;
        }
    }
}

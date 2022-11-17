using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public class Shape
    {
        public virtual int Perimeter()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Jestem figurą";
        }

        virtual public int  Area()
        {
            return 0;
        }

    }
}

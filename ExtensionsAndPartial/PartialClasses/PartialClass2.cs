using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;

namespace ExtensionsAndPartial.PartialClasses
{
    internal partial class PartialClass : MoviePhisical
    {
        public PartialClass() : base("test", 1)
        { 
        
        }

        public void DoSthMore()
        {

        }
    }
}

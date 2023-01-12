using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    public class AlaMaKotaException : Exception
    {
        public AlaMaKotaException() : base("Ala ma kota message")
        {

        }
    }
}

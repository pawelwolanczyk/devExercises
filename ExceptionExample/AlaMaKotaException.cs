using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    internal class AlaMaKotaException : Exception
    {
        public AlaMaKotaException() : base("Ala ma kota message")
        {

        }
    }
}

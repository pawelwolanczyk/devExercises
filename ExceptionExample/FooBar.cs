using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    public class FooBar : Bar
    {
        public FooBar() : base(100)
        {
            Console.WriteLine("Jestem w bezparametrowym konstruktorze klasy FooBar");
            _pole = 300;
        }
    }
}

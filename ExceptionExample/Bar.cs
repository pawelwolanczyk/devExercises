using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    public class Bar : Foo
    {
        public Bar() : base(0)
        {
            Console.WriteLine("Jestem w bezparametrowym konstruktorze klasy Bar");
            _pole = 200;
        }

        public Bar(int a) : this()
        {
            Console.WriteLine("Jestem w parametrowym konstruktorze klasy Bar z wartoscia:" + a);
        }

        //public Bar() : base("beeee")
        //{
        //    Console.WriteLine("Jestem w konstruktorze klasy Bar");
        //}
    }
}

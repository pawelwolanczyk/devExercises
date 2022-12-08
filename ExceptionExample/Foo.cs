using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    public class Foo
    {
        protected int _pole;

        public Foo(int x)
        {
            Console.WriteLine("Jestem w parametrowym konstruktorze klasy Foo z wartoscia: " + x);
            _pole = x;
        }

        public void PrintMe()
        {
            Console.WriteLine("Wartosc to: " + _pole);
        }

        //public Foo(string s)
        //{
        //    Console.WriteLine("Jestem w konstruktorze klasy Foo");
        //}
    }
}

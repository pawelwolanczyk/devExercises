using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloPaweł");

            int xOut;
            double yOut;
            string zOut;

            int xRef = 0;
            double yRef = 0.0;
            string zRef = String.Empty;


            MyMethod1(out xOut, out yOut, out zOut);
            MyMetod2(ref xRef, ref yRef, ref zRef);
        }

        public static void MyMethod1(out int x, out double y, out string z)
        {
            x = 10;
            y = 20.0;
            z = "Ala ma kota";
        }

        public static void MyMetod2(ref int x, ref double y, ref string z)
        {
            x = 10;
            y = 20.0;
        }
    }
}

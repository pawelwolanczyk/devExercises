using System;
using UtilsLibrary.Geometry;

namespace Figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can't call constructor without parameters due to its protection level
            //Rectangle rec = new Rectangle();

            Rectangle rec = new Rectangle(17, 13);
            PrintRectangle(rec);

            //code below will not work as x and y class members are private
            //Console.WriteLine("Podaj bok nr 1:");
            //rec1.x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj bok nr 2:");
            //rec1.y = int.Parse(Console.ReadLine());

            //lets ask user for rectangle details and create new object
            Console.WriteLine("Provide the length of first side of rectangle :");
            int firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Provide the length of second side of rectangle :");
            int secondSide = int.Parse(Console.ReadLine());

            // we can create second Rectangle object and store it in the same rec variable as it was used above
            // C# will take care about releasing memory allocated above (garbage collector)
            rec = new Rectangle(firstSide, secondSide);
            PrintRectangle(rec);
        }

        static void PrintRectangle(Rectangle x)
        {
            Console.WriteLine("Perimeter = " + x.Perimeter());
            Console.WriteLine("Area = " + x.Area());
        }
    }
}

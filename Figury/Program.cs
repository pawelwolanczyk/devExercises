using System;
using UtilsLibrary.Geometry;

namespace Figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape x = null;
            Console.WriteLine("Jaka figure stworzyc? (p/o/t)");
            char figura = Console.ReadLine()[0];
            if (figura == 'p')
                x = new Rectangle(4, 7);
            else if (figura == 'o')
                x = new Circle(5);
            else if (figura == 't')
            {
                //TriangleEquailteral y = new TriangleEquailteral();
                //y.Wysokosc(5);
                //y.Podstawa(8);
                //x = y;
                x = new TriangleEquailteral();
                (x as TriangleEquailteral).Wysokosc(5);
                (x as TriangleEquailteral).Podstawa(8);
            }
            x.PrintObject();   

            //PrintObject(x);
            Console.ReadKey();
            //  OldCode();
        }

        //private static void PrintObject(IShape x)
        //{
        //    Console.WriteLine(x);
        //    Console.WriteLine("Powierzchnia obiektu: " + x.Area());
        //    Console.WriteLine("Obwód obiektu: " + x.Perimeter());
        //}

        private static void OldCode()
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

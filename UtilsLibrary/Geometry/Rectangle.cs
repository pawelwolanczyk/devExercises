﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsLibrary.Geometry
{
    public class Rectangle
    {
        List<int> list1;
        private int x;
        private int y;

        private Rectangle()
        {
            list1 = new List<int>();
            list1.Add(100);
            list1.Add(200);
            Console.WriteLine("Inside constructor without parameters");
        }

        public Rectangle(int a, int b) : this()
        {
            x = a;
            y = b;
            Console.WriteLine("Inside constructor with two ints as parameters");
        }

        public int Area()
        {
            return x * y;
        }

        public int Perimeter()
        {
            return 2 * x + 2 * y;
        }
    }
}
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Joanna
{
    abstract public class Car : ICar
    {
        public abstract string ColorCar();
        public abstract string NameCar();
        public abstract double EngineCapacity();

        public void PrintObject()
        {
            Console.WriteLine(this);
            Console.WriteLine("Samochód nazywa się: " + NameCar());
            Console.WriteLine("Kolor samochodu to: " + ColorCar());
            Console.WriteLine("Pojemność silnika: " + EngineCapacity());
        }
    }
}

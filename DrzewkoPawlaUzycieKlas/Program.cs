using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.PabloTree;

namespace DrzewkoPawlaUzycieKlas
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreePabloUseClass name = new TreePabloUseClass();
            name.PrintName();
            name.NameProperty = Console.ReadLine();
            Console.WriteLine("Wybierz znak: !@#$%^&*)");
            name.EProperty = char.Parse(Console.ReadLine());
            name.LoopMethod();
        }
    }
}

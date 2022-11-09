using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using UtilsLibrary.PabloTree;

namespace DrzewkoPawlaUzycieKlas
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreePabloUseClass Tree = new TreePabloUseClass();
            Tree.ProcesName();
            Console.WriteLine("Wybierz znak: !@#$%^&*)");
            if (!Tree.ProcessSign(char.Parse(Console.ReadLine())))
            {
                TreePabloUseClass.PrintCommunication();
                return;
            }
            Tree.DisplayTree();
        }
    }
}

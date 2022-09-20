// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Immutable;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> lista = new List<int>();
        for (int a = 0; a < args.Length - 1; a++)
        {
            //string s = args[a];
            //int x = int.Parse(s);
            //array[a] = x;
            //args[a] = Console.ReadLine();
            lista.Add(int.Parse(args[a]));
        }
        bool ascending = args[args.Length - 1] == "ascending";
        bool descending = args[args.Length - 1] == "descending";

        int[] array = lista.ToArray();

        if (ascending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write(array[i] + " ,");
            }
        }
        else if (descending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write(array[i] + ", ");
            }
        }
    }
}
//(args.GetLength(int.Parse(Console.ReadLine());
//int[] array = new int[/*args.Length - 1*/] { args.Length - 1/*int.Parse(Console.ReadLine()) */};
//int a = 0;
//args[a] = Console.ReadLine();
//; for (int a = 0; a < args.Length - 1; a++)
//{
//    //string s = args[a];
//    //int x = int.Parse(s);
//    //array[a] = x;
//    array[a] = int.Parse(args[a]);
//}
//bool ascending = args[args.Length - 1] == "ascending";
//bool descending = args[args.Length - 1] == "descending";

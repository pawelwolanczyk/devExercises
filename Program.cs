// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //for ()
        //if (string b = "descending")

        //if (string a = "ascending")
              
        int[] array = new int[] { 39, 12, 34, 21 };

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                    array[i] = array[i];
                else
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[j] = array[i];
                    array[j] = temp;
                }
              
            }
            Console.Write(array[] + ", ");
        }
       
   }

}
// See https://aka.ms/new-console-template for more information
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj ciąg znaków składający się z dużych i małyhch liter: ");
        string expression = Console.ReadLine();
        expression.ToCharArray();
        int liczbaliter = 1;
        int dlugosc = expression.Length;
        int i = 0;
        while ( i < dlugosc)
        {
            int j = i + 1;
            while ( j < dlugosc )
                if (expression[i] == expression[j])
                {
                    liczbaliter++;
                    j++;
                }
                else if (expression[i] != expression[j])
                {
                    j++;
                }
            Console.Write(expression[i]);
            Console.Write("" + liczbaliter + ", ");
            i++;
            while (expression[i] == expression[i-1])
                i++;
        }
          
        //for (int i = 0; i < expression.Length; i++)
        //{
        //    for (int j = i + 1; expression[i] == expression[j]; j++)
        //        if (expression[i] == expression[j])
        //        {
        //            liczbaliter++;
        //        }
        //        else if (expression[i] != expression[j])
        //        {
        //            _ = j < dlugosc;// _ to nie wiem co znaczy, ale podpowiada mi, żebym tak zrobiła :D
        //        }
        //    Console.Write(expression[i]);
        //    Console.Write("" + liczbaliter + ", ");

        //}
    }
}

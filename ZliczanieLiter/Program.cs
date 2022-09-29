// See https://aka.ms/new-console-template for more information
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        Console.WriteLine("Podaj napis składający się z dużych i małych liter:");
        string expression = Console.ReadLine();
        //expression.ToCharArray();
        int liczbaliter;
        int dlugosc = expression.Length;
        int i = 0;
        char[] past = new char[expression.Length];
        int c = 0;
        bool przeprocesowane = false;
        while (i < dlugosc)
        {
            liczbaliter = 1;
            for (int k = 0; k < expression.Length; k++)
            {
                if (expression[i] == past[k])
                {
                    przeprocesowane = true;
                    break;
                }
            }
            if (przeprocesowane)
            {
                przeprocesowane = false;
                i++;
                continue;
            }
            int j = i + 1;
            while (j < dlugosc)
            {
                if (expression[i] == expression[j])
                {
                    //past[c] = expression[j];
                    //c++;
                    liczbaliter++;
                }
                j++;
            }
            past[c] = expression[i];
            c++;
            Console.Write(expression[i]);
            Console.Write(": " + liczbaliter + ", ");
            past[i] = expression[i];
            i++;
        }
    }
}

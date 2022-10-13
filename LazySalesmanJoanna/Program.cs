using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LazySalesmanJoanna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[] {};
            int banknot = int.Parse(args[0]);
            double value = double.Parse(args[1]);
            double money = banknot - value;
            double[] moneys = new double[] { 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            double[] banknots = new double[] { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

            Rest(moneys, money);

            Console.WriteLine("\n Czy są Państwo zadowoleni z obsługi?");
            string answear = Console.ReadLine();
            if (answear == "tak")
            {
                Console.WriteLine("Dziękujemy i zapraszamy ponownie!");
                Console.ReadKey();
            }
            else if (answear == "nie")
            {
                money = banknot - value;
                Rest(banknots,money);
                Console.WriteLine("\n Lepiej być nie może! Miłego dnia!");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Nie rozumiem odpowiedzi, ale mam nadzieję, że jesteś zadowolony. Zapraszamy ponownie!");
            Console.ReadKey();
        }
        static void Rest(double[] n, double m)
        {
            int[] rest = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                double other;
                rest[i] = Convert.ToInt32(Math.Floor(m / n[i]));
                Console.Write(" " + n[i] + "zł:" + " " + rest[i]);
                if (i < n.Length - 1)
                    Console.Write("|");
                other = rest[i] * n[i];
                m = m - other;
            }
        }
    }
}

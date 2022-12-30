using RentalAsia.RentalMovies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int x = 10;


            string klucz1 = "ala";
            string klucz2 = "ala";

            string klucz3 = "ela";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(klucz1, "ma");
            dic.Add("kota", "Mruczka");

            Dictionary<int, int> roomsMap = new Dictionary<int, int>();

            roomsMap.Add(1, 8463952);
            roomsMap.Add(2, 6);
            roomsMap.Add(3, 8463952);

            KeyValuePair<int, int> klucz = new KeyValuePair<int, int>(6, 6);
            roomsMap.Contains(klucz);

            //roomsMap[x];

            //Dictionary<BluRayMovie, string> slownik = new Dictionary<BluRayMovie, string>();
            //slownik.Add(new BluRayMovie("cos", 0), "cokoliek1");
            //slownik.Add(new BluRayMovie("cos1", 2), "cokoliek2");
            //slownik.Add(new BluRayMovie("cos5", 1), "cokoliek3");

            //slownik.ContainsKey(new BluRayMovie("cos", 0));

            if (roomsMap.ContainsKey(10))
            {
                int x2 = roomsMap[10];
            }

            try
            {
                int ileSalekNaPietrze = roomsMap[2];
                throw new NullReferenceException();
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine("Nie ma takiego pietra");
            }
            finally
            {
                Console.WriteLine("finally ups");
                Console.ReadKey();
            }
            Console.WriteLine("ups");

            //Dictionary<string, List<string>> hospital = new Dictionary<string, List<string>>();
            //hospital.Add("Kowalska", KidsGenerator());
        }

        //private static List<string> KidsGenerator()
        //{
        //    List<string> kids = new List<string>();
        //    kids.Add("Kowalski");
        //    kids.Add("Nowak");
        //    kids.Add("Wojcik");

        //    return kids;
        //}
    }
}

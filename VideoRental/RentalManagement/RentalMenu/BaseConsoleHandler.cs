using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;

namespace VideoRental.RentalManagement.RentalMenu
{
    public class BaseConsoleHandler
    {
        public void PrintStartupMovies(List<IMovie> movies)
        {
            Console.WriteLine("--- Lista Kolekcji StartowejPremium:");

            PrintMovies(movies);
        }

        public void PrintAllMovies(List<IMovie> movies)
        {
            Console.WriteLine("--- Lista wszystkich dostępnych filmów:");

            PrintMovies(movies);
        }

        public void PrintExitMessage()
        {
            Console.WriteLine("Miłego dnia!");
        }

        private void PrintMovies(List<IMovie> movies)
        {
            foreach (IMovie movie in movies)
                Console.WriteLine("   - " + movie.Title);

            Console.WriteLine("\nNacisnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}

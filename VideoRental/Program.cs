using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.RentalManagement;
using VideoRental.Users;

namespace VideoRental
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetCurrentClassLogger();
            log.Info("Starting Rental console application");

            Rental rental = new Rental();
            RentalHelper.InitializeRentalPredefinedData(rental);

            //RentalMovies listmovies = new RentalMovies();
            //listmovies.GetAllMovies();

            rental.StartRental();
        }
    }
}

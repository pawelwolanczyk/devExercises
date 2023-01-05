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
            Rental rental = new Rental();
            RentalHelper.InitializeRentalPredefinedData(rental);

            rental.StartRental();
        }
    }
}

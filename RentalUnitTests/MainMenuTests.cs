using NUnit.Framework;
using RentalAsia;
using RentalAsia.RentalMovies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalUnitTests
{
    [TestFixture]
    public class MainMenuTests
    {
        [Test]
        public void TestMenu()
        {
            Rental wypozyczalnia = new Rental();
            RentalAsia.RentalAsia.RentalMovies(wypozyczalnia);
        }
    }
}

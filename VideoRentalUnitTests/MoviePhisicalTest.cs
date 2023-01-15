using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;

namespace VideoRentalUnitTests
{
    [TestFixture]
    public class MoviePhysicalTest
    {
        [Test]
        public void MoviePhisical_numberOfAllPhisicalFilms_True()
        {
            //given //when
            BluRayMovie brmovie = new BluRayMovie("Garfild", 2);
            DvdMovie dvdMovie = new DvdMovie("Za szybko za wściekle", 3);

            //than
            Assert.True(MoviePhisical.CalculateAllFilms_Static() == 5);
        }

        [Test]
        public void MoviePhisical_RentMovieIsTrue()
        {
            MoviePhisical moviePhisical = new BluRayMovie("Garfild", 2);

            Assert.IsTrue(moviePhisical.Rent(DateTime.Now, DateTime.Now.AddDays(1)));
        }
    }
}

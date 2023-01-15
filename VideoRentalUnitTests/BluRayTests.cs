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
    public class BluRayTests
    {
        [Test]
        public void BluRayTitleTest()
        {
            //given//when
            BluRayMovie movie = new BluRayMovie("Garfild", 0);

            //that
            Assert.IsTrue(movie.Title == "Garfild");
        }

        [Test]
        public void BluRay_number_of_copies_IsAvailable()
        {
            //given//when
            BluRayMovie movie = new BluRayMovie("Garfild", 1);

            //that
            Assert.IsTrue(movie.IsAvailable);
        }

        [Test]
        public void BluRay_number_of_copies_IsNotAvailable()
        {
            //given//when
            BluRayMovie movie = new BluRayMovie("Garfild", 0);

            //then
            Assert.IsFalse(movie.IsAvailable);
        }
    }
}

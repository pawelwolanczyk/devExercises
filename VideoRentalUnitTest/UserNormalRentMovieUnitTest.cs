using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Users;
using VideoRental.Movies;

namespace VideoRentalUnitTest
{
    [TestFixture]
    public class NormalUserTests
    {
        [Test]
        public void UserNormal_RentMovieReturnsFalseWhenNoCopiesAvailable()
        {
            //given
            DvdMovie movie = new DvdMovie("Star Trek", 0);
            UserNormal user = new UserNormal("Janusz", "password", 123);

            //when
            bool rentResult = user.RentMovie(movie);

            //then
            Assert.IsFalse(rentResult);

        }

        [Test]
        public void UserNormal_RentMovieReturnsTrueWhenAreCopiesAvailable()
        {
            //given
            DvdMovie movie = new DvdMovie("Star Trek", 1);
            UserNormal user = new UserNormal("Janusz", "password", 123);

            //when
            bool rentResult = user.RentMovie(movie);

            //then
            Assert.IsTrue(rentResult);

        }
    }
}

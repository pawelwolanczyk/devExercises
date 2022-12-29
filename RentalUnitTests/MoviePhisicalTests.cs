using NUnit.Framework;
using RentalAsia.RentalMovies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalUnitTests
{
    [TestFixture]
    public class MoviePhisicalTests
    {
        private MoviePhisical _movie;
        private Rental _rental;

        [OneTimeSetUp]
        public void GeneralPreparation()
        {
            _rental = new Rental();
        }

        [SetUp]
        public void Preparation()
        {
            _movie = new BluRayMovie("Ogniem i mieczem", 1);
        }

        [TearDown]
        public void AtTheEnd()
        {
            int y = 10;
        }

        [Test]
        public void TestIfBluRayMovieIsAvailableAfterRent()
        {
            //then
            Assert.IsTrue(_movie.IsAvailable());
        }

        [Test]
        public void TestIfBluRayMovieIsAvailableAfterRent2()
        {
            //when
            _movie.Rent(DateTime.Now, null);

            //then
            Assert.IsFalse(_movie.IsAvailable());
        }

        [Test]
        public void TestIfStreamingMoveRentThrowsException()
        {
            StreamingMovie movie = new StreamingMovie("Django");

            Assert.Throws<NotImplementedException>(() => movie.Rent(DateTime.Now, null));
        }
    }
}

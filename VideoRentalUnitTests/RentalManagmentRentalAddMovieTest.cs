using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using VideoRental.Movies;
using VideoRental.RentalManagement;
using VideoRental;
using NUnit.Framework.Constraints;

namespace VideoRentalUnitTests
{
    [TestFixture]
    internal class RentalManagmentRentalAddMovieTest
    {
        private RentalMovies _rentalMovies;
        private IMovie _mock;

        [SetUp]
        public void SetUp()
        {
            _rentalMovies = new RentalMovies();
            string movieName = "Garfild";
            Mock<IMovie> internalMock = new Mock<IMovie>();
            internalMock.Setup(x => x.Title).Returns(movieName);
            _mock = internalMock.Object;
        }

        [Test]
        public void AddMovieToList_MovieExist()
        {
            //given
            _rentalMovies.Add(_mock);

            //then 
            Assert.IsTrue(_rentalMovies.Contains(_mock));
        }

        [Test]
        public void FindMovieInTheListRentalMovies_True()
        {
            //given
            string movieName = "Garfild";

            //when
            _rentalMovies.Add(_mock);
            var film = _rentalMovies.Find(movieName);

            //then
            Assert.IsTrue(_mock.Title == film.Title);
            Assert.AreEqual(movieName, film.Title);
        }

        [Test]
        public void FindMovieInTheListRentalMovies_False()
        {
            //given
            string moviesName = "Garfild";
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(moviesName);
            RentalMovies movies = new RentalMovies();

            //when
            movies.Add(mock.Object);
            var film = movies.Find("Blondynk w koszarach");

            //then
            Assert.IsNull(film);
        }

        [Test]
        public void FindMovieInTheListRentalMovies_ButItIsNotAvailable()
        {
            //given
            string movieName = "Garfild";
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(movieName);
            mock.Setup(x => x.IsAvailable).Returns(false);
            RentalMovies movies = new RentalMovies();

            //when
            movies.Add(mock.Object);
            var film = movies.Find("Garfild");

            //then
            Assert.IsTrue(movies.Contains(film));
            Assert.False(film.IsAvailable);

        }

        [Test]
        public void FindMovieInTheListRentalMovies_TrueButOnlyStreamingMovie()
        {
            //given
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(mock.Object.Title);
            RentalMovies movies = new RentalMovies();

            //when
            movies.Add(mock.Object);
            var film = movies.Find(mock.Object.Title);
            Assert.True(movies.Contains(mock.Object), "Only Streaming Movie");

        }
    }
}

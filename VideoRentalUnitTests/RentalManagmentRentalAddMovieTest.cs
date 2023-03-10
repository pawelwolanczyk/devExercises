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
        [Test]
        public void AddMovieToList_True()
        {
            //given
            var mock = new Mock<IMovie>();
            RentalMovies mockList = new RentalMovies();

            //when
            mockList.Add(mock.Object);


            //then 
            Assert.IsTrue(mockList.Contains(mock.Object));
        }

        [Test]
        public void FindMovieInTheListRentalMovies_True()
        {
            //given
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(mock.Object.Title);
            RentalMovies movies = new RentalMovies();

            //when
            movies.Add(mock.Object);
            var film = movies.Find(mock.Object.Title);

            //then
            Assert.IsTrue(movies.Contains(mock.Object));
        }

        [Test]
        public void FindMovieInTheListRentalMovies_False()
        {
            //given
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(mock.Object.Title);
            RentalMovies movies = new RentalMovies();

            //when
            var film = movies.Find(mock.Object.Title);

            //then
            Assert.False(movies.Contains(film));
        }
        [Test]
        public void FindMovieInTheListRentalMovies_ButItIsNotAvailable()
        {
            //given
            var mock = new Mock<IMovie>();
            mock.Setup(x => x.Title).Returns(mock.Object.Title);
            mock.Setup(x => x.IsAvailable).Returns(false);
            RentalMovies movies = new RentalMovies();

            //when
            movies.Add(mock.Object);
            var film = movies.Find(mock.Object.Title);
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

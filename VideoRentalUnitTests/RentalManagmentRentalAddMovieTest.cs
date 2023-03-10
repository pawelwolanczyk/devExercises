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

namespace VideoRentalUnitTests
{
    [TestFixture]
    internal class RentalManagmentRentalAddMovieTest
    {
        [Test]
        public void AddMovieToList_allMovies()
        {
            //given
            BluRayMovie movie = new BluRayMovie("Garfild", 2);
            Mock<IMovie> mock = new Mock<IMovie>();
            mock.Setup(i => i.Title).Returns(movie.Title);
            mock.Setup(i => i.IsAvailable).Returns(true);
            mock.Setup(i => i.Rent(DateTime.Now, DateTime.Now.AddDays(1)));

            //when
            var authentication = new Rental();
            RentalMovies _allMovies = new RentalMovies();
            IMovie movieTitle = mock.Object;
            authentication.AddMovie(movieTitle);

            //then 
            Assert.True(_allMovies[0] == movieTitle);
        }
    }
}

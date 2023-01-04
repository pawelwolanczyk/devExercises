using NUnit.Framework;
using RentalAsia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RentalAsia.RentalMovies;

namespace RentalUnitTests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void TestSave()
        {
            //given
            Mock<IDbConnection> mockConnection = new Mock<IDbConnection>();
            Mock<IDbCommand> mockCommand = new Mock<IDbCommand>();
            Mock<BluRayMovie> mockBR = new Mock<BluRayMovie>();
            mockConnection.Setup(x => x.CreateCommand()).Returns(mockCommand.Object);
            mockCommand.Setup(x => x.CommandText).Returns("");

            //IDbConnection dbConnection = new FakeDbConnection();

            //when
            User user = new User();
            user.Save(mockConnection.Object);

            //then
            Assert.IsTrue(user.Saved);
        }
    }
}

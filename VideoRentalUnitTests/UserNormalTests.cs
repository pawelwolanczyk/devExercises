using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Users;

namespace VideoRentalUnitTests
{
    [TestFixture]
    public class UserNormalTests
    {
        private UserNormal newuser;
        [SetUp]
        public void ObjectUserNormalSetUp()
        {
            newuser = new UserNormal("Asia", "Szymek", 05050505555);
        }
        [Test]
        public void UserNormaGetPasswordIsTrue()
        {
            string password = "Szymek";

            Assert.IsTrue(newuser.GetPassword() == password);
        }

        [Test]
        public void UserNormalGetUserNameIsTrue()
        {
            string userName = "Asia";

            Assert.IsTrue(newuser.GetUserName() == userName);
        }

        [Test]
        public void UserNormalGetPeselIsTrue()
        {
            long pesel = 05050505555;

            Assert.IsTrue(newuser.GetPESEL() == pesel);
        }
    }
}

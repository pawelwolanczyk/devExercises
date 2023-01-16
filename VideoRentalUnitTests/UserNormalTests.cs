using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Users;

namespace VideoRentalUnitTests
{
    [TestFixture]
    public class UserNormalTests
    {
        [Test]
        public void UserNormaGetPasswordIsTrue()
        {
            //given//when
            string password = "Szymek";
            UserNormal newuser = new UserNormal("Asia", password, 05050505555);

            //then
            Assert.IsTrue(newuser.GetPassword() == password);
        }

        [Test]
        public void UserNormalGetUserNameIsTrue()
        {
            //given//when
            string userName = "Asia";
            UserNormal newuser = new UserNormal(userName, "Szymek", 05050505555);

            //then
            Assert.IsTrue(newuser.GetUserName() == userName);
        }

        [Test]
        public void UserNormalGetPeselIsTrue()
        {
            //given//when
            long pesel = 05050505555;
            UserNormal newuser = new UserNormal("Asia", "Szymek", pesel);

            //then
            Assert.IsTrue(newuser.GetPESEL() == pesel);
        }
    }
}

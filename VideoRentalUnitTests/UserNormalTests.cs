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
            UserNormal newuser = new UserNormal("Asia", "Szymek", 05050505555);

            //then
            Assert.IsTrue(newuser.GetPassword() == newuser._password);
        }
        [Test]
        public void UserNormalGetUserNameIsTrue()
        {
            //given//when
            UserNormal newuser = new UserNormal("Asia", "Szymek", 05050505555);

            //then
            Assert.IsTrue(newuser.GetUserName() == newuser._userName);
        }
        [Test]
        public void UserNormalGetPeselIsTrue()
        {
            //given//when
            UserNormal newuser = new UserNormal("Asia", "Szymek", 05050505555);

            //then
            Assert.IsTrue(newuser.GetPESEL() == newuser._pesel);
        }
    }
}

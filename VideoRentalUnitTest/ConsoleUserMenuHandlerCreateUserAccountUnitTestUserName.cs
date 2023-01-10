using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.RentalManagement.RentalMenu;

namespace VideoRentalUnitTest
{
    [TestFixture]
    public class ConsoleUserMenuHandlerCreateUserAccountUnitTestUserName
    {
        [Test]
        public void GetTrueFromCreateUserAccountIcanNotAddUserByNameAsia()
        {
            var accountAsia = new ConsoleUserMenuHandler();

            var result = accountAsia.GetUserLogin("Asia");

            Assert.IsFalse(result == "Asia");
           
        }
    }
}

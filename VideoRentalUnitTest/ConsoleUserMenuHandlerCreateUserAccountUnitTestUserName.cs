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
        public void SearchExceptionInCreateUserAccountIfUserNameIsAsia()
        {
            var accountAsia = new ConsoleUserMenuHandler();

            Assert.Throws<Exception>(() => accountAsia.GetUserLogin("Asia"));
        }

        [Test]
        public void CreateUserAccountIfUserNameIsAsia()//zmieniec nazwe
        {
            var accountothers = new ConsoleUserMenuHandler();

            Assert.DoesNotThrow(() => accountothers.GetUserLogin("Andrzej"));
        }
        [Test]
        public void PomyslecNadNazwa()//zmienic nazwe 
        {
            var accountothers = new ConsoleUserMenuHandler();

            Assert.IsTrue(accountothers.GetUserLogin("Bartek").Equals("Bartek"));
        }
    }
}

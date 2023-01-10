using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.Users;

namespace VideoRental.RentalManagement.RentalMenu
{
    internal class ConsoleAdminMenuHandler : BaseConsoleHandler
    {
        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        internal void AdminLogin()
        {
            //it should not be here but inside admin/user class - there should be Login method returning true/false;
            string adminPassword = "admin";
            
            while (true)
            {
                Console.WriteLine("PODAJ HASLO ADMINISTRATORA");
                string pass = Console.ReadLine();
                if (pass == adminPassword)
                {
                    _logger.Debug("Administrator zalogował się.");
                    break;
                }
            }
        }

        internal void PrintUsers(List<IUser> users)
        {
            Console.WriteLine("--- Lista uzytkownikow bazowych: ");
            foreach (IUser user in users)
                Console.WriteLine("   - " + user.GetUserName());
        }

        internal void HandleNotLoggedInAdmin()
        {
            Console.WriteLine("Administrator nie jest zalogowany. Musisz się zalogować aby wykonać inne operacje.");
        }
    }
}

using VideoRental.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using VideoRental.RentalManagement.RentalMenu;
using System.Runtime.Remoting;
using System.Linq.Expressions;

namespace VideoRental.RentalManagement
{
    internal class Rental
    {
        private RentalMovies _allMovies = new RentalMovies();
        private RentalMovies _startupCollection = new RentalMovies();
        private RentalUsers _users = new RentalUsers();
        
        public void AddMovie(IMovie movie)
        {
            _allMovies.Add(movie);
        }

        public void AddUser(RentalUserType userType, string userName, string password, long pesel)
        {
            if (userType == RentalUserType.StandardUser)
                _users.Add(new UserNormal(userName, password, pesel));
            else if (userType == RentalUserType.PremiumUser)
                _users.Add(new UserPremium(userName, password, pesel, _startupCollection));
            else
                throw new Exception("Unknow user type (cannot add other users than standard or premium");
        }

        public bool AddMovieToStartupCollection(string movieTitle)
        {
            StreamingMovie streamingMovie = _allMovies.Find(movieTitle) as StreamingMovie;
            if (streamingMovie != null)
            {
                _startupCollection.Add(streamingMovie);
                return true;
            }

            return false;
        }

        public List<string> GetTitlesStartingList()
        {
            List<string> startListTitles = new List<string>();
            foreach (IMovie movie in _startupCollection)
            {
                startListTitles.Add(movie.Title);
            }

            return startListTitles;
        }

        public List<IMovie> GetStartupCollection()
        {
            return _startupCollection;
        }

        public IUser FindUser(string userName)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].GetUserName() == userName)
                {
                    return _users[i];
                }
            }

            return null;
        }

        public void StartRental()
        {
            IUser user = null;
            bool adminAlreadyLoggedIn = false;
            IMenu programMenu = new ConsoleMenu();
            programMenu.InitialMenu();
            AppUserType appUser = programMenu.SelectUserType();
            if (appUser == AppUserType.Unknown)
                return;

            while (true)
            {
                if (appUser == AppUserType.Administrator)
                {
                    if (HandleAdminOperation(programMenu.AdminMenu(), ref adminAlreadyLoggedIn) == AdminOperation.Exit)
                        return;
                }
                else if (appUser == AppUserType.User)
                {
                    UserOperation operation = programMenu.UserMenu();
                    if (operation == UserOperation.Login)
                    {
                        user = HandleUserLogin();
                        if (user == null)
                            return;
                    }
                    else if (HandleUserOperation(operation, user) == UserOperation.Exit)
                        return;
                }
            }
        }

        private AdminOperation HandleAdminOperation(AdminOperation operation, ref bool adminAlreadyLoggedIn)
        {
            ConsoleAdminMenuHandler menuHandler = new ConsoleAdminMenuHandler();

            if (operation != AdminOperation.Login && !adminAlreadyLoggedIn)
            {
                menuHandler.HandleNotLoggedInAdmin();
                return operation;
            }

            switch (operation)
            {
                case AdminOperation.Login:
                    menuHandler.AdminLogin();
                    adminAlreadyLoggedIn = true;
                    break;
                case AdminOperation.PrintUsers:
                    menuHandler.PrintUsers(_users);
                    break;
                case AdminOperation.PrintStartupMovies:
                    menuHandler.PrintStartupMovies(_startupCollection);
                    break;
                case AdminOperation.PrintAllMovies:
                    menuHandler.PrintAllMovies(_allMovies);
                    break;
                case AdminOperation.Exit:
                    menuHandler.PrintExitMessage();
                    break;
            }

            return operation;
        }

        private UserOperation HandleUserOperation(UserOperation operation, IUser loggedUser)
        {
            ConsoleUserMenuHandler menuHandler = new ConsoleUserMenuHandler();
            try
            {
                switch (operation)
                {
                    case UserOperation.CreateAccount:
                        IUser createdUser = menuHandler.CreateUserAccount();
                        if (createdUser as UserPremium != null)
                            (createdUser as UserPremium).ProcessStartupCollection(_startupCollection);
                        _users.Add(createdUser);
                        break;
                    case UserOperation.PrintAvailableMovies:
                        menuHandler.PrintAllMovies(_allMovies);
                        break;
                    case UserOperation.PrintUserData:
                        menuHandler.PrintUserData(loggedUser);
                        break;
                    case UserOperation.PrintRentedMovies:
                        menuHandler.PrintRentedMovies(loggedUser);
                        break;
                    case UserOperation.RentMovie:
                        string movieTitle = menuHandler.RentMovie(loggedUser);
                        if (String.IsNullOrEmpty(movieTitle))
                            return operation;
                        IMovie movieToRent = _allMovies.Find(movieTitle);
                        if (movieToRent == null)
                            menuHandler.HandleNotExistingMovie();
                        loggedUser.RentMovie(movieToRent);
                        menuHandler.HandleRentSuccessfull();
                        break;
                }
            }
            catch (UserNotLoggedInException)
            {
            }
            return operation;
        }

        private IUser HandleUserLogin()
        {
            ConsoleUserMenuHandler menuHandler = new ConsoleUserMenuHandler();
            int incorrectLoginCounter = 0;

            do
            {
                try
                {
                    IUser user = FindUser(menuHandler.UserLogin());
                    if (user == null)
                        menuHandler.HandleIncorrectLogin();

                    if (user.GetPassword() != menuHandler.Authenticate())
                        menuHandler.HandleIncorrectPasword();

                    return user;
                }
                catch (InvalidUserCredentialsException)
                {
                    incorrectLoginCounter++;
                }
            }
            while (incorrectLoginCounter < 3);

            return null;
        }
    }
}

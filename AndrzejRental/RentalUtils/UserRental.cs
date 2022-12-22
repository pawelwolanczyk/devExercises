using AndrzejRental.UserUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.RentalUtils
{
    internal class UserRental
    {
        List<IUser> _usersList = new List<IUser>();


        public void AddUser(IUser User)
        {
            _usersList.Add(User);
        }


        public List<IUser> GetUsers()
        {
            return _usersList;
        }

        public List<string> GetUsersNames()
        {
            List<string> usersNames = new List<string>();
            foreach (IUser user in _usersList)
            {
                usersNames.Add(user.GetUserName());
            }
            return usersNames;
        }

        public IUser FindUser(string userName)
        {
            for (int i = 0; i < _usersList.Count; i++)
            {
                if (_usersList[i].GetUserName() == userName)
                {
                    return _usersList[i];
                }
            }
            return null;
        }

        public int GetAllUsersCount
        {
            get
            {
                int AllUsersCount = UserNormal.GetUsersNormalCount();
                return AllUsersCount;
            }
        }
        public int GetPremiumUsersCount
        {
            get
            {
                int PremiumUsersCount = UserPremium.GetUsersPremiumCount();
                return PremiumUsersCount;
            }
        }


    }
}

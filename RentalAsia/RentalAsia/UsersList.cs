using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public class UsersList : List<IUser>
    {

        private List<IUser> _users = new List<IUser>();
        public void AddNewUser(IUser UserLogin)
        {
            _users.Add(UserLogin);
        }
    }
}

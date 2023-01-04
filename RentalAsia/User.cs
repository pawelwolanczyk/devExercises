using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public class User
    {
        private string _login;
        private string _password;

        private bool _savedToDb = false;

        public void Save(IDbConnection dbConnection)
        {
            try
            {
                IDbCommand command = dbConnection.CreateCommand();
                command.CommandText = "INSERT INTO Users VALUES ()";
                command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                return;
            }

            _savedToDb = true;
        }

        public bool Saved
        {
            get { return _savedToDb; }
        }
    }
}

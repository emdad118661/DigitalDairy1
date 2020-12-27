using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDairy1
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            return userDataAccess.LoginValidation(username, password);
        }
    }
}

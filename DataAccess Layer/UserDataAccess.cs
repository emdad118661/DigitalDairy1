using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DigitalDairy1
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            
                if (reader.Read())
                {

                    return true;
                }
                return false;
            
            
        }
    }
}

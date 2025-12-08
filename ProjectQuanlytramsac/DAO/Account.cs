using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanlytramsac.DAO
{
    public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; } 
            private set { instance = value; }
        }

        private Account() { }





        public bool login(string username, string password)
        {
            string query = "SELECT * FROM Account WHERE username = N'" + username + "' AND password = N'" + password +"'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW__커피샵_프로그램
{
    public class UserManager
    {
        public string loginID { get; set; }
        public string name { get; set; }
        public string permission { get; set; }
        private static UserManager instance = new UserManager();

        public static UserManager GetInstance()
        {
            return instance;
        }

        public UserManager()
        {
            this.loginID = null;
            this.name = null;
            this.permission = null;
        }

        public void login(string loginID, string name, string permission)
        {
            this.loginID = loginID;
            this.name = name;
            this.permission = permission;

            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO coffee_user_log(login_id, name, type, datetime) " +
                "VALUES('" + loginID + "', '" + name + "', '"+ "login" + "', '" + now + "');";

            DBManager.GetInstance().Insert(query);
        }

        public void logout()
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO coffee_user_log(login_id, name, type, datetime) " +
                "VALUES('" + loginID + "', '" + name + "', '" + "logout" + "', '" + now + "');";
            DBManager.GetInstance().Insert(query);

            this.loginID = null;
            this.name = null;
            this.permission = null;
        }
    }
}

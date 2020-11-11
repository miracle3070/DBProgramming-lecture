using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW__커피샵_프로그램
{
    public class LoginUser
    {
        public string loginID { get; }
        public string name { get; }

        public LoginUser(string loginID, string name)
        {
            this.loginID = loginID;
            this.name = name;
        }
    }
}

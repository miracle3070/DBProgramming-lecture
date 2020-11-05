using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    class DBManager
    {
        private static DBManager instance = new DBManager();
        string strConn = "Server=49.50.174.201;Database=s5671309;Uid=s5671309;Pwd=s5671309;Charset=utf8";

        public static DBManager GetInstance()
        {
            return instance;
        }

        private DBManager()
        {

        }

        public void Insert(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }


        public void msg(string msg)
        {
            MessageBox.Show(msg, "확인");
        }
    }
}

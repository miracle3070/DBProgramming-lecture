using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using Renci.SshNet.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW_09__학생정보관리___MySQL___Singleton_class
{
    public class DBManager
    {
        private static DBManager instance = new DBManager();
        private string connection_string = "Server=49.50.174.201;Database=s5671309;Uid=s5671309;Pwd=s5671309;Charset=utf8";
        private MySqlConnection conn;

        public static DBManager getInstance()
        {
            return instance;
        }

        private DBManager()
        {
            conn = new MySqlConnection(connection_string);
            conn.Open();

        }

        public MySqlDataReader select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }

        public void insert(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void update(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void delete(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

    }
}

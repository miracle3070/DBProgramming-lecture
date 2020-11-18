using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

    class QueryManager
    {
        public QueryManager()
        {

        }

        string query = "";

        public static QueryManager Select(string columns)
        {
            QueryManager instance = new QueryManager();

            instance.query = "SELECT " + columns + " ";

            return instance;
        }

        public QueryManager From(string table)
        {
            query += " FROM " + table;

            return this;
        }

        public QueryManager Where(string where)
        {
            query += " WHERE " + where;

            return this;
        }

        public QueryManager GroupBy(string groupby)
        {
            query += " Group By " + groupby;

            return this;
        }

        public DataTable Exec()
        {
            DataTable dt = new DataTable();

            MessageBox.Show("Query = " + query, "확인");

            // DBManager 실행

            return dt;
        }


    }
}

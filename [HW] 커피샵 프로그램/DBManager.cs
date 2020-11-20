using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW__커피샵_프로그램
{
    public class DBManager
    {
        private static DBManager instance = new DBManager();
        private string strConn = "Server=49.50.174.201;Database=s5671309;Uid=s5671309;Pwd=s5671309;Charset=utf8";
        private MySqlConnection conn;

        public DBManager()
        {
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public static DBManager GetInstance()
        {
            return instance;
        }

        // DB에 Select 쿼리를 날려서 받아온 데이터가 담긴 MySqlDataReader를 반환
        public MySqlDataReader Select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        // Select 메소드를 이용해서 열었던 MySqlDataReader를 닫는 메소드
        public bool SelectClose(MySqlDataReader rdr)
        {
            try
            {
                rdr.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Insert(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void Update(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

    }


    public class QueryManager
    {
        private string query;

        public QueryManager()
        {
            this.query = "";
        }

        public static QueryManager Select(string columns)
        {
            QueryManager instance = new QueryManager();
            instance.query += "SELECT " + columns;
            return instance;
        }

        public QueryManager From(string table)
        {
            query += " FROM " + table;

            return this;
        }

        public QueryManager Join(string tables)
        {
            query += " JOIN " + tables;

            return this;
        }

        public QueryManager On(string condition)
        {
            query += " ON " + condition;

            return this;
        }

        public QueryManager Where(string where)
        {
            query += " WHERE " + where;

            return this;
        }

        public QueryManager GroupBy(string groupBy)
        {
            query += " GROUP BY " + groupBy;

            return this;
        }
        
        public DataTable SelectExec()
        {
            query += ";";
            DataTable dt = new DataTable();

            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            dt.Load(rdr);
            DBManager.GetInstance().SelectClose(rdr);

            return dt;
        }
    }
}

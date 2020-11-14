using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW__커피샵_프로그램
{
    public partial class FormShowUserLog : Form
    {
        public FormShowUserLog()
        {
            InitializeComponent();
        }

        private void FormShowUserLog_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM coffee_user_log;";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "아이디";
            dt.Columns[2].ColumnName = "이름";
            dt.Columns[3].ColumnName = "유형";
            dt.Columns[4].ColumnName = "발생 시간";

            dataGridViewUserLog.DataSource = dt;
            dataGridViewUserLog.Columns["발생 시간"].Width = 200;
            DBManager.GetInstance().SelectClose(rdr);
        }
    }
}

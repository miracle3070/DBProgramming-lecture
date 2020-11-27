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
    public partial class FormMenuModifyLog : Form
    {
        public FormMenuModifyLog()
        {
            InitializeComponent();
        }

        private void FormMenuModifyLog_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM coffee_kind_modify";
            MySqlDataReader rdr = DBManager.GetInstance().Select(select_query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "변경한 유저";
            dt.Columns[2].ColumnName = "커피 ID";
            dt.Columns[3].ColumnName = "이전 이름";
            dt.Columns[4].ColumnName = "이전 가격";
            dt.Columns[5].ColumnName = "변경된 이름";
            dt.Columns[6].ColumnName = "변경된 가격";
            dt.Columns[7].ColumnName = "변경 일시";

            dataGridViewLog.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }
    }
}

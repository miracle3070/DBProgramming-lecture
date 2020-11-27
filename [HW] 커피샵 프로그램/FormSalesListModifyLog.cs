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
    public partial class FormSalesListModifyLog : Form
    {
        public FormSalesListModifyLog()
        {
            InitializeComponent();
        }

        private void FormSalesListModifyLog_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM coffee_sales_modify;";
            MySqlDataReader rdr = DBManager.GetInstance().Select(select_query);
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "변경한 유저";
            dt.Columns[2].ColumnName = "판매 직원";
            dt.Columns[3].ColumnName = "판매 일시";
            dt.Columns[4].ColumnName = "주문 번호";
            dt.Columns[5].ColumnName = "이전 커피ID";
            dt.Columns[6].ColumnName = "이전 개수";
            dt.Columns[7].ColumnName = "이전 가격";
            dt.Columns[8].ColumnName = "이전 상태";
            dt.Columns[9].ColumnName = "변경된 커피ID";
            dt.Columns[10].ColumnName = "변경된 개수";
            dt.Columns[11].ColumnName = "변경된 가격";
            dt.Columns[12].ColumnName = "변경된 상태";
            dt.Columns[13].ColumnName = "변경 일시";

            dataGridViewLog.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }
    }
}

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
    public partial class FormSearchSalesList : Form
    {
        public FormSearchSalesList()
        {
            InitializeComponent();
        }

        public void LoadSearchResult()
        {
            string dateTime = dateTimePicker1.Value.ToString("yyyy-MM-dd HH");
            DataTable dt = QueryManager.Select("t1.id, t1.login_id, t1.order_number, t1.coffee_id, " +
                "t2.name, t1.count, t1.price, t1.datetime, t1.status").From("coffee_sales t1").
                Join("coffee_kind t2").On("t1.coffee_id = t2.id").
                Where("datetime like '" + dateTime + "%'").SelectExec();

            dataGridViewSearchResult.DataSource = dt;
            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "판매직원";
            dt.Columns[2].ColumnName = "주문번호";
            dt.Columns[3].ColumnName = "커피 ID";
            dt.Columns[4].ColumnName = "커피 종류";
            dt.Columns[5].ColumnName = "개수";
            dt.Columns[6].ColumnName = "가격";
            dt.Columns[7].ColumnName = "판매시간";
            dt.Columns[8].ColumnName = "상태";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadSearchResult();
        }

        // 주문 취소하기 버튼을 누르면 동작하는 메소드
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string currentStatus = dataGridViewSearchResult.CurrentRow.Cells["상태"].Value.ToString();
            if(currentStatus != "취소")
            {
                string selectedID = dataGridViewSearchResult.CurrentRow.Cells["순번"].Value.ToString();
                string sql = "UPDATE coffee_sales SET status='취소' WHERE id=" + selectedID + ";";
                DBManager.GetInstance().Update(sql);

                LoadSearchResult();
                MessageBox.Show("취소되었습니다.", "알림");
            }
            else
            {
                MessageBox.Show("이미 취소된 항목입니다.", "알림");
                return;
            }
           
            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormSearchSalesListModify newForm = new FormSearchSalesListModify(this);
            newForm.ShowDialog();
        }
    }
}

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
    public partial class FormSearchSalesList : Form
    {
        public FormSearchSalesList()
        {
            InitializeComponent();
        }

        // 실제 주문 리스트를 불러오는 메소드
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

        // 검색하기 버튼을 눌렀을때 호출되는 메소드
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadSearchResult();
        }

        // 주문 취소하기 버튼을 누르면 동작하는 메소드
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string currentStatus = dataGridViewSearchResult.CurrentRow.Cells["상태"].Value.ToString();
            
            if(currentStatus != "취소")   // 취소 상태가 아닌지 체크
            {
                // 취소 이력을 주문 이력 수정 테이블에 추가
                string selectedID = dataGridViewSearchResult.CurrentRow.Cells["순번"].Value.ToString();
                string select_query = "SELECT * FROM coffee_sales WHERE id=" + selectedID + ";";
                MySqlDataReader rdr = DBManager.GetInstance().Select(select_query);
                rdr.Read();

                string loginID = UserManager.GetInstance().loginID;
                string salesLoginID = rdr["login_id"].ToString();
                DateTime time = (DateTime)rdr["datetime"];
                string salesDatetime = time.ToString("yyyy-MM-dd HH:mm:ss");
                string orderNumber = rdr["order_number"].ToString();
                string pastCoffeeID = rdr["coffee_id"].ToString();
                string pastCount = rdr["count"].ToString();
                string pastPrice = rdr["price"].ToString();
                string pastStatus = rdr["status"].ToString();
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                DBManager.GetInstance().SelectClose(rdr);

                string insert_query = "INSERT INTO coffee_sales_modify(login_id, sales_login_id, " +
                "sales_datetime, order_number, past_coffee_id, past_count, past_price, past_status, " +
                "modified_status, datetime) " +
                "VALUES('" + loginID + "', '" + salesLoginID + "', '" + salesDatetime + "', " +
                orderNumber + ", " + pastCoffeeID + ", " + pastCount + ", " + pastPrice + ", '" + pastStatus + "', '" +
                "취소" + "', '" + currentTime + "');";
                DBManager.GetInstance().Insert(insert_query);

                // 취소 상태로 설정
                string sql = "UPDATE coffee_sales SET status='취소' WHERE id=" + selectedID + ";";
                DBManager.GetInstance().Update(sql);

                // 주문 내역 새로고침
                LoadSearchResult();
                MessageBox.Show("취소되었습니다.", "알림");
            }
            else  // 취소 상태면 메시지 박스만 출력 후 리턴
            {
                MessageBox.Show("이미 취소된 항목입니다.", "알림");
                return;
            }                   
        }


        // 수정하기 버튼을 눌었을때 동작하는 메소드
        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormSearchSalesListModify newForm = new FormSearchSalesListModify(this);
            newForm.ShowDialog();
        }
    }
}

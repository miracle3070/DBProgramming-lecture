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
    public partial class FormSearchSalesListModify : Form
    {
        private FormSearchSalesList parent; // 선택된 커피 정보를 이어받아 오기 위해 선언

        // 생성자
        public FormSearchSalesListModify(FormSearchSalesList parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitVariables();
        }

        // 수정을 희망하는 주문에 대한 정보를 수정창에 로드하는 메소드
        public void InitVariables()
        {
            DataGridViewRow selectedRow = parent.dataGridViewSearchResult.CurrentRow;
            textBoxSalesID.Text = selectedRow.Cells["순번"].Value.ToString();
            textBoxSeller.Text = selectedRow.Cells["판매직원"].Value.ToString();
            textBoxOrderNumber.Text = selectedRow.Cells["주문번호"].Value.ToString();
            textBoxCoffeeID.Text = selectedRow.Cells["커피 ID"].Value.ToString();
            textBoxCoffeeCount.Text = selectedRow.Cells["개수"].Value.ToString();
            comboBoxCoffeeKind.Text = selectedRow.Cells["커피 종류"].Value.ToString();

            string sql = "SELECT name FROM coffee_kind;";
            MySqlDataReader rdr = DBManager.GetInstance().Select(sql);
            while(rdr.Read())
            {
                comboBoxCoffeeKind.Items.Add(rdr["name"]);
            }

            DBManager.GetInstance().SelectClose(rdr);

        }

        // comboBox 값이 달라졌을때 커피ID textBox 값을 자동으로 바꿔주는 메소드
        private void comboBoxCoffeeKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coffeeName = comboBoxCoffeeKind.Text;
            string sql = "SELECT id FROM coffee_kind WHERE name='" + coffeeName + "';";

            MySqlDataReader rdr = DBManager.GetInstance().Select(sql);
            rdr.Read();

            textBoxCoffeeID.Text = rdr["id"].ToString();
            DBManager.GetInstance().SelectClose(rdr);
        }

        // 수정하기 버튼을 클릭했을떄 동작하는 메소드
        private void buttonModify_Click(object sender, EventArgs e)
        {
            string coffeeID = textBoxCoffeeID.Text;
            string coffeeName = comboBoxCoffeeKind.Text;
            string coffeeCount = textBoxCoffeeCount.Text;

            // 선택된 커피 개당 가격 구하기
            string sql1 = "SELECT price FROM coffee_kind WHERE name='" + coffeeName + "';";
            MySqlDataReader rdr = DBManager.GetInstance().Select(sql1);
            rdr.Read();
            string coffeePrice = rdr["price"].ToString();
            DBManager.GetInstance().SelectClose(rdr);

            // 전체 커피값 계산
            int totalPrice = Convert.ToInt32(coffeePrice) * Convert.ToInt32(coffeeCount);


            // 주문 정보 변경 이력 추가
            string loginID = UserManager.GetInstance().loginID;
            string salesID = textBoxSalesID.Text;
            string select_query = "SELECT * FROM coffee_sales WHERE id=" + salesID + ";";
            rdr = DBManager.GetInstance().Select(select_query);
            rdr.Read();

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
                "modified_coffee_id, modified_count, modified_price, modified_status, datetime) " +
                "VALUES('" + loginID + "', '" + salesLoginID + "', '" + salesDatetime + "', " +
                orderNumber + ", " + pastCoffeeID + ", " + pastCount + ", " + pastPrice + ", '" + pastStatus + "', " +
                coffeeID + ", " + coffeeCount + ", " + totalPrice + ", '" + pastStatus + "', '" +
                currentTime + "');";
            DBManager.GetInstance().Insert(insert_query);

            // 실제 DB에 있는 내용 수정
            string sql2 = "UPDATE coffee_sales SET coffee_id=" + coffeeID +
                ", count=" + coffeeCount + ", price=" + totalPrice.ToString() +
                " WHERE id=" + textBoxSalesID.Text + ";";
            DBManager.GetInstance().Update(sql2);

            parent.LoadSearchResult();
            MessageBox.Show("수정이 완료되었습니다.");
        }
    }
}

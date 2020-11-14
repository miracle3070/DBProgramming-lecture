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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 커피 판매처리 메소드
        private void buttonSell_Click(object sender, EventArgs e)
        {
            string selectedCoffeeID = dataGridViewCoffee.CurrentRow.Cells["순번"].Value.ToString();
            string query = "SELECT * FROM coffee_kind WHERE id=" + selectedCoffeeID + ";";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();

            if (rdr.HasRows == false)
            {
                MessageBox.Show("존재하지 않는 메뉴입니다.", "오류");
                DBManager.GetInstance().SelectClose(rdr);
                return;
            }

            string loginID = UserManager.GetInstance().loginID;
            string price = rdr["price"].ToString();
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string coffeeName = rdr["name"].ToString();
            DBManager.GetInstance().SelectClose(rdr);

            query = "INSERT INTO coffee_sales(login_id, coffee_id, sales, date) " +
                "VALUES('" + loginID + "', " + selectedCoffeeID + ", " + price + ", '" + date + "');";

            DBManager.GetInstance().Insert(query);
            MessageBox.Show(coffeeName + " 이(가) 판매되었습니다.", "알림");
        }

        // 사용자별 일일 판매량, 판매액을 출력해주는 메소드
        private void btnShowDailyUserSalesList_Click(object sender, EventArgs e)
        {
            string permission = UserManager.GetInstance().permission;

            if (permission != "1")
            {
                MessageBox.Show("관리자만 사용 가능합니다.");
                return;
            }

            string query = "SELECT date, login_id, count(*), sum(sales) " +
                "FROM coffee_sales GROUP BY date, login_id;";

            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "날짜";
            dt.Columns[1].ColumnName = "캐셔 ID";
            dt.Columns[2].ColumnName = "일일 판매량";
            dt.Columns[3].ColumnName = "일일 판매액";

            dataGridViewAdminScreen.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }

        // 커피 종류별 일일 판매량, 판매액을 출력해주는 메소드
        private void btnShowDailyCoffeeSalesList_Click(object sender, EventArgs e)
        {
            string permission = UserManager.GetInstance().permission;

            if (permission != "1")
            {
                MessageBox.Show("관리자만 사용 가능합니다.");
                return;
            }

            string query = "SELECT date, t2.name, count(*), sum(sales) " +
                "FROM coffee_sales t1 JOIN coffee_kind t2 ON t1.coffee_id = t2.id " +
                "GROUP BY date, coffee_id;";

            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "날짜";
            dt.Columns[1].ColumnName = "커피 종류";
            dt.Columns[2].ColumnName = "일일 판매량";
            dt.Columns[3].ColumnName = "일일 판매액";

            dataGridViewAdminScreen.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }

        // 커피 종류별 월별 누적 판매량, 판매액을 보여주는 메소드
        private void btnShowMonthlyCoffeeSalesLIst_Click(object sender, EventArgs e)
        {
            string permission = UserManager.GetInstance().permission;

            if (permission != "1")
            {
                MessageBox.Show("관리자만 사용 가능합니다.");
                return;
            }

            string query = "SELECT DATE_FORMAT(date, '%Y-%m') m, t2.name, COUNT(*), SUM(sales) " +
                "FROM coffee_sales t1 JOIN coffee_kind t2 ON t1.coffee_id = t2.id " +
                "GROUP BY m, t2.name;";

            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "년도-월";
            dt.Columns[1].ColumnName = "커피 종류";
            dt.Columns[2].ColumnName = "월 판매량";
            dt.Columns[3].ColumnName = "월 판매액";

            dataGridViewAdminScreen.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }

        // 메인 창이 로드되면 수행하는 동작
        private void Form1_Load(object sender, EventArgs e)
        {
            // 로그인한 사용자 이름 표시
            string name = UserManager.GetInstance().name;
            labelLoginUser.Text = name + "님 반갑습니다!";

            // 캐셔용 화면의 커피 리스트 로드
            LoadCoffeeList();
        }

        private void 판매메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string permission = UserManager.GetInstance().permission;

            if(permission != "1")
            {
                MessageBox.Show("관리자만 이용 가능한 기능입니다.", "오류");
                return;
            }

            FormMenuManager newForm = new FormMenuManager();
            newForm.Show();
        }

        private void 사용자로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string permission = UserManager.GetInstance().permission;

            if (permission != "1")
            {
                MessageBox.Show("관리자만 이용 가능한 기능입니다.", "오류");
                return;
            }            

            FormShowUserLog newForm = new FormShowUserLog();
            newForm.Show();
        }

        // 로그아웃 버튼을 누르면 수행되는 동작
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 캐셔용 화면의 새로고침 버튼을 누르면 동작하는 메소드
        private void buttonLoadCoffee_Click(object sender, EventArgs e)
        {
            LoadCoffeeList();
        }

        // 캐셔용 화면에 커피 리스트를 띄우는 메소드
        private void LoadCoffeeList()
        {
            string query = "SELECT * FROM coffee_kind;";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);

            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "이름";
            dt.Columns[2].ColumnName = "가격";

            dataGridViewCoffee.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }

    }
}

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
        private LoginUser loginUser;
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            loginUser = null;
        }

        // 로그인 기능을 수행하는 메소드
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = textBoxID.Text;
            string inputPW = textBoxPW.Text;

            string query = "SELECT * FROM coffee_user WHERE login_id='" + inputID + "' AND password='" + inputPW + "';";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();

            if (rdr.HasRows == false) // 입력한 아이디, 비번에 대한 유저가 없을때
            {
                DBManager.GetInstance().SelectClose(rdr);
                MessageBox.Show("아이디 또는 비밀번호를 잘못 입력하셨습니다.", "알림");
                return;
            }
            else // 입력한 아이디, 비번에 대한 유저 정보를 찾았을때
            {
                loginUser = new LoginUser(rdr["login_id"].ToString(), rdr["name"].ToString());
                labelLoginUser.Text = loginUser.name + "님 로그인 되었습니다.";
                DBManager.GetInstance().SelectClose(rdr);
            }
        }

        // 로그아웃을 수행하는 메소드
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(loginUser == null)
            {
                MessageBox.Show("이미 로그아웃 상태입니다.", "알림");
            }

            loginUser = null;
            labelLoginUser.Text = "먼저 로그인을 해주세요.";
        }

        // 아메리카노 판매 처리
        private void btnSellAmericano_Click(object sender, EventArgs e)
        {
            if(loginUser == null)
            {
                MessageBox.Show("로그인 후 이용해주세요.", "알림");
                return;
            }
            
            string query = "INSERT INTO coffee_sales(login_id, coffee_id, sales, date) " +
                "VALUES('" + loginUser.loginID + "', 1, 1000, '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');";
            DBManager.GetInstance().Insert(query);

            MessageBox.Show("아메리카노 판매 완료!", "알림");
        }

        // 라떼 판매 처리
        private void btnSellLatte_Click(object sender, EventArgs e)
        {
            if (loginUser == null)
            {
                MessageBox.Show("로그인 후 이용해주세요.", "알림");
                return;
            }

            string query = "INSERT INTO coffee_sales(login_id, coffee_id, sales, date) " +
                "VALUES('" + loginUser.loginID + "', 2, 1500, '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');";
            DBManager.GetInstance().Insert(query);

            MessageBox.Show("라떼 판매 완료!", "알림");
        }

        // 카페모카 판매 처리
        private void btnSellCafeMocha_Click(object sender, EventArgs e)
        {
            if (loginUser == null)
            {
                MessageBox.Show("로그인 후 이용해주세요.", "알림");
                return;
            }

            string query = "INSERT INTO coffee_sales(login_id, coffee_id, sales, date) " +
                "VALUES('" + loginUser.loginID + "', 3, 2000, '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');";
            DBManager.GetInstance().Insert(query);

            MessageBox.Show("카페모카 판매 완료!", "알림");
        }

        // 사용자별 일일 판매량, 판매액을 출력해주는 메소드
        private void btnShowDailyUserSalesList_Click(object sender, EventArgs e)
        {
            if (loginUser == null || loginUser.loginID != "admin")
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
            if (loginUser == null || loginUser.loginID != "admin")
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
            if (loginUser == null || loginUser.loginID != "admin")
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
    }
}

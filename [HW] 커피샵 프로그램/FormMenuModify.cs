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
    public partial class FormMenuModify : Form
    {
        private string selectedMenu;

        public FormMenuModify()
        {
            InitializeComponent();
        }

        public void SetSelectedMenu(string selectedMenu)
        {
            this.selectedMenu = selectedMenu;
        }

        private void buttonMenuModify_Click(object sender, EventArgs e)
        {
            string coffeeID = textBoxCoffeeID.Text;
            string inputName = textBoxCoffeeName.Text;
            string inputPrice = textBoxCoffeePrice.Text;
            int temp = 0;

            // 메뉴와 가격을 모두 입력했는지 확인
            if(inputName == "" || inputPrice == "")
            {
                MessageBox.Show("메뉴 이름과 가격을 모두 입력해주세요.", "오류");
                return;
            }
            
            // 가격 칸에 입력한 값이 정수인지 확인
            if(!int.TryParse(inputPrice, out temp))
            {
                MessageBox.Show("가격에는 정수값만 입력해주세요.", "오류");
                return;
            }

            // 커피 정보 변경 이력 추가
            string select_query = "SELECT * FROM coffee_kind WHERE id=" + coffeeID + ";";
            MySqlDataReader rdr = DBManager.GetInstance().Select(select_query);
            rdr.Read();

            string past_name = rdr["name"].ToString();
            string past_price = rdr["price"].ToString();
            DBManager.GetInstance().SelectClose(rdr);
            string loginID = UserManager.GetInstance().loginID;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string log_query = "INSERT INTO coffee_kind_modify(login_id, coffee_id, past_name, " +
                "past_price, modified_name, modified_price, datetime)" +
                "VALUES('" + loginID + "', " + coffeeID + ", '" + past_name + "', " + past_price +
                ", '" + inputName + "', " + inputPrice + ", '" + currentTime + "');";
            DBManager.GetInstance().Insert(log_query);


            // 커피 정보 업데이트
            string query = "UPDATE coffee_kind SET name='" + inputName + "', " +
                "price=" + inputPrice + " WHERE id=" + coffeeID + ";";

            DBManager.GetInstance().Update(query);
            MessageBox.Show("메뉴 수정이 완료되었습니다!", "알림");
        }

        private void FormMenuModify_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM coffee_kind WHERE id=" + this.selectedMenu + ";";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();

            textBoxCoffeeID.Text = rdr["id"].ToString();
            textBoxCoffeeName.Text = rdr["name"].ToString();
            textBoxCoffeePrice.Text = rdr["price"].ToString();
            DBManager.GetInstance().SelectClose(rdr);
        }
    }
}

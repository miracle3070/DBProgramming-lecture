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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
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
                string name = rdr["name"].ToString();
                string permission = rdr["permission"].ToString();
                DBManager.GetInstance().SelectClose(rdr);

                UserManager.GetInstance().login(inputID, name, permission);
                this.Hide();    // 로그인 창 숨기기
                Form1 newForm = new Form1();
                newForm.ShowDialog(); // 커피 판매창 띄우기
                this.Close(); // 로그인 창 종료
            }
            
        }
    }
}

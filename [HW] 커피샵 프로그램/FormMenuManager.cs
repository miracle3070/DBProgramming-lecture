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
    public partial class FormMenuManager : Form
    {
        public FormMenuManager()
        {
            InitializeComponent();
        }

        // 커피 메뉴를 DB로부터 읽어서 dataGridView에 출력해주는 메소드
        private void LoadMenu()
        {
            string query = "SELECT * FROM coffee_kind;";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dt.Columns[0].ColumnName = "순번";
            dt.Columns[1].ColumnName = "메뉴 이름";
            dt.Columns[2].ColumnName = "가격";

            dataGridViewMenu.DataSource = dt;
            DBManager.GetInstance().SelectClose(rdr);
        }

        private void FormMenuManager_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void buttonShowMenuAddForm_Click(object sender, EventArgs e)
        {
            FormMenuAdd newForm = new FormMenuAdd();
            newForm.Show();
        }

        private void buttonLoadMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void buttonShowMenuModifyForm_Click(object sender, EventArgs e)
        {
            // 현재 선택된 Row의 메뉴 기본키를 selectedMenu에 저장
            string selectedMenu = dataGridViewMenu.CurrentRow.Cells["순번"].Value.ToString();
            
            // 메뉴 수정 폼 띄우기
            FormMenuModify newForm = new FormMenuModify();
            newForm.SetSelectedMenu(selectedMenu);
            newForm.Show();
        }
    }
}

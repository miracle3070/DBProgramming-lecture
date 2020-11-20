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
        private FormSearchSalesList parent;
        public FormSearchSalesListModify(FormSearchSalesList parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitVariables();
        }

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

        private void comboBoxCoffeeKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coffeeName = comboBoxCoffeeKind.Text;
            string sql = "SELECT id FROM coffee_kind WHERE name='" + coffeeName + "';";

            MySqlDataReader rdr = DBManager.GetInstance().Select(sql);
            rdr.Read();

            textBoxCoffeeID.Text = rdr["id"].ToString();
            DBManager.GetInstance().SelectClose(rdr);
        }

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

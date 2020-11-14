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
    public partial class FormMenuAdd : Form
    {
        public FormMenuAdd()
        {
            InitializeComponent();
        }

        private void buttonMenuAdd_Click(object sender, EventArgs e)
        {
            string inputCoffee = textBoxCoffeeName.Text;
            string inputPrice = textBoxCoffeePrice.Text;

            string query = "INSERT INTO coffee_kind(name, price) " +
                "VALUES('" + inputCoffee + "', " + inputPrice + ");";

            DBManager.GetInstance().Insert(query);
            MessageBox.Show(inputCoffee + "이(가) 추가되었습니다.", "알림");
        }
    }
}

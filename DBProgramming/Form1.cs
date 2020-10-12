using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thisIsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요!!");
        }

        private void bbbb_Click(object sender, EventArgs e)
        {
            System.String str = "최고의 인생을 꿈꾸십니까?\n그걸 저와 함께 이루시죠!";
            MessageBox.Show(str);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxOperator.Items.Clear();
            comboBoxOperator.Items.Add("+");
            comboBoxOperator.Items.Add("-");
            comboBoxOperator.Items.Add("*");
            comboBoxOperator.Items.Add("/");
            comboBoxOperator.Items.Add("^");
            comboBoxOperator.SelectedIndex = 0;

            RadioOperatorPlus.Checked = true;
        }

        private void comboBoxCalculate_Click(object sender, EventArgs e)
        {
            String oper1 = comboBoxOperand1.Text;
            String oper2 = comboBoxOperand2.Text;
            double result = 0;

            if (comboBoxOperator.SelectedIndex < 4)
            {
                // 입력받은 피연산자를 double형으로 전환 (+, -, *, / 에 사용)
                double operand1 = Convert.ToDouble(oper1);
                double operand2 = Convert.ToDouble(oper2);

                switch (comboBoxOperator.SelectedIndex)
                {
                    case 0: // +
                        result = operand1 + operand2;
                        break;
                    case 1: // -
                        result = operand1 - operand2;
                        break;
                    case 2: // *
                        result = operand1 * operand2;
                        break;
                    case 3: // /
                        result = operand1 / operand2;
                        break;
                }
            }
            else
            {
                // 입력받은 피연산자를 int형으로 전환 (^ 연산에 사용)
                int operand1 = Convert.ToInt32(oper1);
                int operand2 = Convert.ToInt32(oper2);

                result = 1;
                for (int i = 0; i < operand2; i++)
                    result *= operand1;
            }

            comboBoxResult.Text = result.ToString();
        }

        private void RadioCalculate_Click(object sender, EventArgs e)
        {
            String oper1 = RadioOperand1.Text;
            String oper2 = RadioOperand2.Text;

            double operand1 = Convert.ToDouble(oper1);
            double operand2 = Convert.ToDouble(oper2);
            double result = 0;

            if (RadioOperatorPlus.Checked == true)
                result = operand1 + operand2;
            else
                result = operand1 - operand2;

            RadioResult.Text = result.ToString();

        }
    }
}

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

namespace Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string gender = textBoxGender.Text;
            StudentInfo sinfo = new StudentInfo(name, gender);

            string query = "INSERT INTO student(name, gender) VALUES('" + name + "', '" + gender + "');";

            DBManager.GetInstance().Insert(query);

         //   string query = "INSERT INTO TABLE(..) VALEUS(...);";
        //    MyManager.GetInstance().insert(query);
        }

        string strConn = "Server=49.50.174.201;Database=s5671309;Uid=s5671309;Pwd=s5671309;Charset=utf8";

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string query = "SELECT * FROM student;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                dataGridViewStudentList.DataSource = dt;
                rdr.Close();
            }
        }
    }
}

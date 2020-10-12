using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private bool loadCompleted_ = false;
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Clear();
            string[] gender = { "남자", "여자" };
            comboBoxStudent3Gender.Items.AddRange(gender);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
        }



        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {

        }



        private void saveStudent1()
        {
         //   if (loadCompleted_ == false)
         //       return;

            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent1Name.Text;
            studentInfo.sid = textBoxStudent1ID.Text;
            studentInfo.gender = comboBoxStudent1Gender.Text;

            Stream ws = new FileStream("student.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, studentInfo);
            ws.Close();

            /*
            StreamWriter sw = new StreamWriter(new FileStream("student.dat", FileMode.Create));
            sw.WriteLine(textBoxStudent1Name.Text);
            sw.WriteLine(textBoxStudent1ID.Text);
            sw.WriteLine(comboBoxStudent1Gender.Text);

            sw.Close();
            */
        }

        #region Student 1 Event Handler
        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
            //saveStudent1();
        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
           // saveStudent1();
        }

        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
           // saveStudent1();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            saveStudent1();
        }
        #endregion



        private void loadStudent1()
        {
            /*
            StreamReader sr = new StreamReader(new FileStream("student.dat", FileMode.Open));
            string student1Name = sr.ReadLine();
            string student1ID = sr.ReadLine();
            string student1Gender = sr.ReadLine();
            */

            Stream rs = new FileStream("student.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();
            StudentInfo studentInfo = (StudentInfo)deserializer.Deserialize(rs);

            textBoxStudent1Name.Text = studentInfo.name;
            textBoxStudent1ID.Text = studentInfo.sid;
            comboBoxStudent1Gender.Text = studentInfo.gender;

            rs.Close();

            //sr.Close();
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            loadStudent1();
            loadCompleted_ = true;
        }
    }
}

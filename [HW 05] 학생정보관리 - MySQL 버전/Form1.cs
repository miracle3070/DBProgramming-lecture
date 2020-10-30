using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW_02__학생정보관리
{
    public partial class Form1 : Form
    {
        string strConn = "Server=49.50.174.201;Database=s5671309;Uid=s5671309;Pwd=s5671309;Charset=utf8";
        public Form1()
        {
            InitializeComponent();
            InitVariables();    // comboBox 초기화
            InitSettings();     // 학생정보 자동 불러오기 여부 확인
        }

        // 각 학생들의 comboBox 요소를 초기화 한다.
        private void InitVariables()
        {
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent3Gender.Items.Clear();

            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Add("남자");
            comboBoxStudent3Gender.Items.Add("여자");
        }

        // 학생정보를 자동으로 불러오는 것을 선택했는지 확인하고
        // 선택됬었다면 학생정보들을 불러온다.
        private void InitSettings()
        {
            try
            {
                StreamReader sr = new StreamReader(new FileStream("settings.ini", FileMode.Open));
                string[] autoLoadFlag = (sr.ReadLine()).Split('=');
                sr.Close();

                if(autoLoadFlag[1] == "1")
                {
                    checkBoxAutoLoad.Checked = true;
                    loadStudentInfo();
                }
            }
            catch(FileNotFoundException ex)
            {
                StreamWriter sw = new StreamWriter(new FileStream("settings.ini", FileMode.Create));
                sw.WriteLine("AutoLoad=0");
                sw.Close();

            }
        }


        /* 
         * "프로그램 시작시 자동으로 학생정보 로드" 체크시
         * settings.ini에 'AutoLoad=1' 기록
         * 
         * 체크 해제시 settings.ini에 'AutoLoad=0' 기록
         */
        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(new FileStream("settings.ini", FileMode.Create));
            if (checkBoxAutoLoad.Checked == true)
                sw.WriteLine("AutoLoad=1");
            else
                sw.WriteLine("AutoLoad=0");

            sw.Close();
        }


        // 학생수와 각 학생들의 정보를 "student.dat"에 순차적으로 기록
        private void saveStudent()//int studentNumber)
        {
            string command = "INSERT INTO student_info VALUES(1, \'" +
                textBoxStudent1Name.Text + "\', \'" + textBoxStudent1ID.Text + "\', \'" +
                comboBoxStudent1Gender.Text + "\', \'" + textBoxStudent1Memo.Text + "\');";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(command, conn);
                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("이미 정보가 들어가 있네??");
                }
                
            }
            /*
            int studentCount = 0;
            if (textBoxStudent1Name.Text != "학생정보 없음" && textBoxStudent1Name.Text != "")
                studentCount++;
            if (textBoxStudent2Name.Text != "학생정보 없음" && textBoxStudent2Name.Text != "")
                studentCount++;
            if (textBoxStudent3Name.Text != "학생정보 없음" && textBoxStudent3Name.Text != "")
                studentCount++;


            BinaryWriter bw = new BinaryWriter(new FileStream("student.dat", FileMode.Create));
            bw.Write(studentCount);

            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxStudent1Memo.Text);

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxStudent2Memo.Text);

            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxStudent3Memo.Text);
            bw.Close();

            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
            */
        }


        // "student.dat" 파일로부터 학생들의 정보를 읽어온다.
        private void loadStudentInfo()
        {
            BinaryReader br = new BinaryReader(new FileStream("student.dat", FileMode.Open));
            int studentCount = br.ReadInt32();
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();

            textBoxStudent1Name.Text = br.ReadString();
            textBoxStudent1ID.Text = br.ReadString();
            comboBoxStudent1Gender.Text = br.ReadString();
            textBoxStudent1Memo.Text = br.ReadString();

            textBoxStudent2Name.Text = br.ReadString();
            textBoxStudent2ID.Text = br.ReadString();
            comboBoxStudent2Gender.Text = br.ReadString();
            textBoxStudent2Memo.Text = br.ReadString();

            textBoxStudent3Name.Text = br.ReadString();
            textBoxStudent3ID.Text = br.ReadString();
            comboBoxStudent3Gender.Text = br.ReadString();
            textBoxStudent3Memo.Text = br.ReadString();

            br.Close();
        }
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            loadStudentInfo();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            saveStudent();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            saveStudent();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            saveStudent();
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.Text = "";
            textBoxStudent1Memo.Text = "";
            saveStudent();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.Text = "";
            textBoxStudent2Memo.Text = "";
            saveStudent();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.Text = "";
            textBoxStudent3Memo.Text = "";
            saveStudent();
        }


    }
}

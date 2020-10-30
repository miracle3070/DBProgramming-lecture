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

namespace _HW_05__학생정보관리___MySQL
{
    public partial class Form1 : Form
    {
        int studentCount = 0;
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

                if (autoLoadFlag[1] == "1")
                {
                    checkBoxAutoLoad.Checked = true;
                    loadStudentInfo();
                }
            }
            catch (FileNotFoundException ex)
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

        // 테이블에 저장된 학생 수를 찾아서 studentCount 변수를 설정하는 함수
        private void setStudentCount()
        {
            string sql = "SELECT COUNT(*) FROM student_info;";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                studentCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // 테이블로부터 학생들의 정보를 읽어와서 각 요소에 문자열로 대입시킨다.
        private void loadStudentInfo()
        {
            string sql = "SELECT * FROM student_info";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["id"].ToString() == "1")
                    {
                        textBoxStudent1Name.Text = rdr["st_name"].ToString();
                        textBoxStudent1ID.Text = rdr["st_id"].ToString();
                        comboBoxStudent1Gender.Text = rdr["st_gender"].ToString();
                        textBoxStudent1Memo.Text = rdr["st_memo"].ToString();
                    }
                    else if (rdr["id"].ToString() == "2")
                    {
                        textBoxStudent2Name.Text = rdr["st_name"].ToString();
                        textBoxStudent2ID.Text = rdr["st_id"].ToString();
                        comboBoxStudent2Gender.Text = rdr["st_gender"].ToString();
                        textBoxStudent2Memo.Text = rdr["st_memo"].ToString();
                    }
                    else
                    {
                        textBoxStudent3Name.Text = rdr["st_name"].ToString();
                        textBoxStudent3ID.Text = rdr["st_id"].ToString();
                        comboBoxStudent3Gender.Text = rdr["st_gender"].ToString();
                        textBoxStudent3Memo.Text = rdr["st_memo"].ToString();
                    }
                }
            }
            setStudentCount();
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "학생정보 불러오기" 버튼을 눌렀을때 동작하는 함수
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            loadStudentInfo();
        }

        // "저장" 버튼을 눌렀을때 해당 학생의 정보를 테이블에 삽입하거나 수정하는 함수
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            string student1Name = "\'" + textBoxStudent1Name.Text + "\'";
            string student1ID = textBoxStudent1ID.Text;
            string student1Gender = "\'" + comboBoxStudent1Gender.Text + "\'";
            string student1Memo = "\'" + textBoxStudent1Memo.Text + "\'";            

            // 학번을 입력하지 않고 저장을 시도할 경우 오류메시지 출력
            if(student1ID == "")
            {
                MessageBox.Show("학번은 필수로 입력해야 합니다.", "오류");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                // 해당 학생 정보가 테이블에 없으면 ROW를 새로 생성한다.
                try
                {
                    string sql = "INSERT INTO student_info VALUES(1, " +
                        student1Name + ", " + student1ID + ", " +
                        student1Gender + ", " + student1Memo + ");";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    studentCount++; // 학생 수 증가
                }
                // 해당 학생 정보가 이미 테이블에 있으면 UPDATE를 수행한다.
                catch (MySqlException ex)
                {
                    string sql = "UPDATE student_info SET st_name=" + student1Name +
                        ", st_id=" + student1ID + ", st_gender=" + student1Gender +
                        ", st_Memo=" + student1Memo + " WHERE id=1;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "저장" 버튼을 눌렀을때 해당 학생의 정보를 테이블에 삽입하거나 수정하는 함수
        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            string student2Name = "\'" + textBoxStudent2Name.Text + "\'";
            string student2ID = textBoxStudent2ID.Text;
            string student2Gender = "\'" + comboBoxStudent2Gender.Text + "\'";
            string student2Memo = "\'" + textBoxStudent2Memo.Text + "\'";

            // 학번을 입력하지 않고 저장을 시도할 경우 오류메시지 출력
            if (student2ID == "")
            {
                MessageBox.Show("학번은 필수로 입력해야 합니다.", "오류");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                // 해당 학생 정보가 테이블에 없으면 ROW를 새로 생성한다.
                try
                {
                    string sql = "INSERT INTO student_info VALUES(2, " +
                        student2Name + ", " + student2ID + ", " +
                        student2Gender + ", " + student2Memo + ");";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    studentCount++; // 학생 수 증가
                }
                // 해당 학생 정보가 이미 테이블에 있으면 UPDATE를 수행한다.
                catch (MySqlException ex)
                {
                    string sql = "UPDATE student_info SET st_name=" + student2Name +
                        ", st_id=" + student2ID + ", st_gender=" + student2Gender +
                        ", st_Memo=" + student2Memo + " WHERE id=2;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "저장" 버튼을 눌렀을때 해당 학생의 정보를 테이블에 삽입하거나 수정하는 함수
        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            string student3Name = "\'" + textBoxStudent3Name.Text + "\'";
            string student3ID = textBoxStudent3ID.Text;
            string student3Gender = "\'" + comboBoxStudent3Gender.Text + "\'";
            string student3Memo = "\'" + textBoxStudent3Memo.Text + "\'";

            // 학번을 입력하지 않고 저장을 시도할 경우 오류메시지 출력
            if (student3ID == "")
            {
                MessageBox.Show("학번은 필수로 입력해야 합니다.", "오류");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                // 해당 학생 정보가 테이블에 없으면 ROW를 새로 생성한다.
                try
                {
                    string sql = "INSERT INTO student_info VALUES(3, " +
                        student3Name + ", " + student3ID + ", " +
                        student3Gender + ", " + student3Memo + ");";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    studentCount++; // 학생 수 증가
                }
                // 해당 학생 정보가 이미 테이블에 있으면 UPDATE를 수행한다.
                catch (MySqlException ex)
                {
                    string sql = "UPDATE student_info SET st_name=" + student3Name +
                        ", st_id=" + student3ID + ", st_gender=" + student3Gender +
                        ", st_Memo=" + student3Memo + " WHERE id=3;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "삭제" 버튼을 눌렀을때 해당 학생의 정보를 테이블에서 삭제하는 함수
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM student_info WHERE id=1;";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.Text = "";
            textBoxStudent1Memo.Text = "";

            setStudentCount();
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "삭제" 버튼을 눌렀을때 해당 학생의 정보를 테이블에서 삭제하는 함수
        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM student_info WHERE id=2;";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.Text = "";
            textBoxStudent2Memo.Text = "";

            setStudentCount();
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }

        // "삭제" 버튼을 눌렀을때 해당 학생의 정보를 테이블에서 삭제하는 함수
        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM student_info WHERE id=3;";
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.Text = "";
            textBoxStudent3Memo.Text = "";

            setStudentCount();
            labelStudentCount.Text = "현재 저장된 학생 수: " + studentCount.ToString();
        }
    }
}

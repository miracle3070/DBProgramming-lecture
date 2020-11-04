using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _HW_09__학생정보관리___MySQL___Singleton_class
{
    public partial class MainForm : Form
    {
        private MajorInfo majorInfo = new MajorInfo();
        private StudentInfo student = new StudentInfo();
        public MainForm()
        {
            InitializeComponent();
            InitVariables(); // 콤보 박스 초기화
            studentInfoAutoLoad(); // 학생정보 자동 로드
        }

        // 콤보 박스(성별) 요소 초기화
        private void InitVariables()
        {
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");
            comboBoxStudent1Gender.SelectedIndex = 0;

            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");
            comboBoxStudent2Gender.SelectedIndex = 0;

            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.Add("남자");
            comboBoxStudent3Gender.Items.Add("여자");
            comboBoxStudent3Gender.SelectedIndex = 0;
        }

        // 전공 추가 버튼 이벤트 처리 메소드
        private void buttonMajorCreate_Click(object sender, EventArgs e)
        {
            if (textBoxMajor.Text == "신규전공입력하세요")
                return;
            
            string newMajor = textBoxMajor.Text;
            majorInfo.addMajor(newMajor);

            // 전공에 관한 리스트 박스에 새로운 전공 추가
            listBoxMajorList.Items.Add(newMajor);
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            student.setStudentInfo(1, textBoxStudent1Name.Text,
                textBoxStudent1ID.Text, comboBoxStudent1Gender.Text);

            saveStudentInfo(student);
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            student.setStudentInfo(2, textBoxStudent2Name.Text,
               textBoxStudent2ID.Text, comboBoxStudent2Gender.Text);

            saveStudentInfo(student);
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            student.setStudentInfo(3, textBoxStudent3Name.Text,
               textBoxStudent3ID.Text, comboBoxStudent3Gender.Text);

            saveStudentInfo(student);
        }

        private void saveStudentInfo(StudentInfo student)
        {
            int majorId = getSelectedMajorId();

            if(isExist(majorId, student.getStudentIndex()))
            {
                string updateQuery = "UPDATE student_info_ver2 SET std_name=\'" + student.getStudentName() +
                    "\', std_id=\'" + student.getStudentId() + "\', std_gender=\'" + student.getStudentGender() +
                    "\' WHERE major_id=" + majorId.ToString() + " AND std_idx=" + student.getStudentIndex() + ";";

                DBManager.getInstance().update(updateQuery);
            }
            else
            {
                string insertQuery = "INSERT INTO student_info_ver2" +
                "(major_id, std_idx, std_name, std_id, std_gender) VALUES(" +
                majorId.ToString() + ", " + student.getStudentIndex().ToString() +
                ", \'" + student.getStudentName() + "\', \'" + student.getStudentId() +
                "\', \'" + student.getStudentGender() + "\');";

                DBManager.getInstance().insert(insertQuery);
            }
        }

        private bool isExist(int majorId, int studentIdx)
        {
            string selectQuery = "SELECT * FROM student_info_ver2 WHERE "
                + "major_id=" + majorId.ToString() + " AND std_idx=" + studentIdx.ToString() + ";";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            bool result;

            if (rdr.Read())
                result = true;
            else
                result = false;

            rdr.Close();
            return result;
        }

        private void buttonStudentInfoLoad_Click(object sender, EventArgs e)
        {
            loadStudentInfo();
        }

        private void loadStudentInfo()
        {
            string selectQuery = "SELECT major_name FROM major";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            while(rdr.Read())
            {
                listBoxMajorList.Items.Add(rdr["major_name"].ToString());
            }
            rdr.Close();
            try
            {
                if(checkUsingRecentlyUsed())
                    RecentlyUsedFirst();
                else
                    listBoxMajorList.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void listBoxMajorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearStudentInfoBox();
            int majorId = getSelectedMajorId();

            string selectQuery = "SELECT * FROM student_info_ver2 WHERE major_id=" + majorId.ToString() + ";";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            while(rdr.Read())
            {
                if(Convert.ToInt32(rdr["std_idx"]) == 1)
                {
                    textBoxStudent1Name.Text = rdr["std_name"].ToString();
                    textBoxStudent1ID.Text = rdr["std_id"].ToString();

                    if (rdr["std_gender"].ToString() == "남자")
                        comboBoxStudent1Gender.SelectedIndex = 0;
                    else
                        comboBoxStudent1Gender.SelectedIndex = 1;

                }
                else if (Convert.ToInt32(rdr["std_idx"]) == 2)
                {
                    textBoxStudent2Name.Text = rdr["std_name"].ToString();
                    textBoxStudent2ID.Text = rdr["std_id"].ToString();

                    if (rdr["std_gender"].ToString() == "남자")
                        comboBoxStudent2Gender.SelectedIndex = 0;
                    else
                        comboBoxStudent2Gender.SelectedIndex = 1;
                }
                else
                {
                    textBoxStudent3Name.Text = rdr["std_name"].ToString();
                    textBoxStudent3ID.Text = rdr["std_id"].ToString();

                    if (rdr["std_gender"].ToString() == "남자")
                        comboBoxStudent3Gender.SelectedIndex = 0;
                    else
                        comboBoxStudent3Gender.SelectedIndex = 1;
                }
            }
            rdr.Close();

            string updateQuery = "UPDATE config SET recent_major=" + majorId.ToString() + ";";
            DBManager.getInstance().update(updateQuery);
        }

        // 사용자에게 보여지는 학생정보 화면을 초기화하는 메소드
        private void clearStudentInfoBox()
        {
            textBoxStudent1Name.Text = "";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.SelectedIndex = 0;

            textBoxStudent2Name.Text = "";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.SelectedIndex = 0;

            textBoxStudent3Name.Text = "";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.SelectedIndex = 0;
        }

        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            string updateQuery;
            if(checkBoxAutoLoad.Checked)
            {
                updateQuery = "UPDATE config SET auto_load=1 WHERE id=1;";
                DBManager.getInstance().update(updateQuery);
            }
            else
            {
                updateQuery = "UPDATE config SET auto_load=0 WHERE id=1;";
                DBManager.getInstance().update(updateQuery);
            }
        }

        private void studentInfoAutoLoad()
        {
            /*
            string selectQuery = "SELECT auto_load FROM config WHERE id=1;";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            int autoLoad = Convert.ToInt32(rdr["auto_load"]);
            rdr.Close();
            */

            int autoLoad = ConfigManager.getInstance().getAutoLoad();

            if(autoLoad == 1)
            {
                checkBoxAutoLoad.Checked = true;
                loadStudentInfo();
            }
            else
            {
                checkBoxAutoLoad.Checked = false;
            }
        }

        private int getSelectedMajorId()
        {
            // 테이블에서 전공 기본키(major_id) 얻어오기
            string selectedMajor = listBoxMajorList.SelectedItem.ToString();
            string selectQuery = "SELECT id FROM major WHERE major_name=" + "\'" + selectedMajor + "\';";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            int majorId = Convert.ToInt32(rdr["id"]);
            rdr.Close();

            return majorId;
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            int majorId = getSelectedMajorId();
            string deleteQuery = "DELETE FROM student_info_ver2 WHERE std_idx=1 AND major_id=" + majorId.ToString() + ";";
            DBManager.getInstance().delete(deleteQuery);

            textBoxStudent1Name.Text = "";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.SelectedIndex = 0;
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            int majorId = getSelectedMajorId();
            string deleteQuery = "DELETE FROM student_info_ver2 WHERE std_idx=2 AND major_id=" + majorId.ToString() + ";";
            DBManager.getInstance().delete(deleteQuery);

            textBoxStudent2Name.Text = "";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.SelectedIndex = 0;
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            int majorId = getSelectedMajorId();
            string deleteQuery = "DELETE FROM student_info_ver2 WHERE std_idx=3 AND major_id=" + majorId.ToString() + ";";
            DBManager.getInstance().delete(deleteQuery);

            textBoxStudent3Name.Text = "";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.SelectedIndex = 0;
        }

        

        private void checkBoxRecentlyUsed_CheckedChanged(object sender, EventArgs e)
        {
            string updateQuery;
            if(checkBoxRecentlyUsed.Checked == true)
                updateQuery = "UPDATE config SET recent_first=1;";
            else
                updateQuery = "UPDATE config SET recent_first=0;";

            DBManager.getInstance().update(updateQuery);
        }

        // "프로그램 시작시 최근 사용 전공 정보 출력" 체크 여부 확인
        private bool checkUsingRecentlyUsed()
        {
            int recentFirst = ConfigManager.getInstance().getRecentFrist();
            bool result;

            if (recentFirst == 0)
            {
                result = false;
            }
            else
            {
                checkBoxRecentlyUsed.Checked = true;
                result = true;
            }

            return result;
        }

        // 최근 사용 전공 정보를 선택하게 하는 메소드
        private void RecentlyUsedFirst()
        {
            int majorId = ConfigManager.getInstance().getRecentMajor();

            string selectQuery = "SELECT major_name FROM major WHERE id=" + majorId.ToString() + ";";
            MySqlDataReader rdr = DBManager.getInstance().select(selectQuery);
            rdr.Read();
            string majorName = rdr["major_name"].ToString();
            rdr.Close();

            listBoxMajorList.SelectedItem = majorName;
        }
    }
}

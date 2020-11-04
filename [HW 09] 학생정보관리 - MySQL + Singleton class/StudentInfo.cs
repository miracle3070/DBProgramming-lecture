using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW_09__학생정보관리___MySQL___Singleton_class
{
    public class StudentInfo
    {
        private int std_idx;
        private string std_name;
        private string std_id;
        private string std_gender;

        public StudentInfo()
        {

        }
        public StudentInfo(string name, string std_id, string std_gender)
        {
            this.std_name = name;
            this.std_id = std_id;
            this.std_gender = std_gender;
        }

        public void setStudentInfo(int idx, string name, string id, string gender)
        {
            std_idx = idx;
            std_name = name;
            std_id = id;
            std_gender = gender;
        }

        public int getStudentIndex()
        {
            return std_idx;
        }

        public string getStudentName()
        {
            return std_name;
        }

        public string getStudentId()
        {
            return std_id;
        }

        public string getStudentGender()
        {
            return std_gender;
        }
    }
}

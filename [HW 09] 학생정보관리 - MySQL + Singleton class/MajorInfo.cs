using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _HW_09__학생정보관리___MySQL___Singleton_class
{
    public class MajorInfo
    {
        private List<string> majorList;

        public MajorInfo()
        {
            majorList = new List<string>();
        }

        public void addMajor(string newMajor)
        {
            string insertQuery = "INSERT INTO major(major_name) VALUES(\'"
                + newMajor + "\');";

            // 전공 테이블(major)에 새로운 전공 추가
            DBManager.getInstance().insert(insertQuery);

            this.majorList.Add(newMajor);  
        }

        public List<string> getMajorList()
        {
            return majorList;
        }
    }
}

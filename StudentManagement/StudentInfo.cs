using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    [Serializable]
    class StudentInfo
    {        
        public string name { get; set; } // 이름
        public string sid { get; set; }  // 학 번
        public string gender { get; set; } //성별

    }
}

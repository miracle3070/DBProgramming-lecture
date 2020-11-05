using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class StudentInfo
    {
        public string name { get; set; }
        public string gender { get; set; }
        public StudentInfo(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
        }
    }
}

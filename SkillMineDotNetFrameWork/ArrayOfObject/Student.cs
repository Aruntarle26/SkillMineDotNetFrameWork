using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ArrayOfObject
{
    class Student
    {
        private int studentid;
        private string studentname;
        private string studentdept;
        public Student(int studentid,string studentname,string studentdept)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.studentdept = studentdept;
        }
        public override string ToString()
        {
            return $"{studentid}   {studentname}   {studentdept}";
        }
    }
}

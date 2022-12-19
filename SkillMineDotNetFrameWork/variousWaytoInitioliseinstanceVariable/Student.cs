using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.variousWaytoInitioliseinstanceVariable
{
    class Student1
    {
        /*private int studentid;
        private string studentname;*/
        /* public Student1(int studentid, string studentname)
         {
             this.studentid = studentid;
             this.studentname = studentname;
         }*/
        public int StudentId { get; set; }//no need ti declare the instance variable
        public string StudentName { get; set; }

        public override string ToString()
        {
            return $"student id is: {StudentId}  studentname is: {StudentName}";
        }
    }
}

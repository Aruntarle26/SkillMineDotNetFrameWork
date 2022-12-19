using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.Basic
{
   public class Student
    {
        private int studentId;
        private string studentName;
        int physicsMark, chemMark, mathMark,total;
        double per;
        private static int count;
        public Student()
        {
        }
        public Student(string studentName,int physicsMark,int chemMark,int mathMark)
        {
            count++;
            this.studentId = count;
            this.studentName = studentName;
            this.physicsMark = physicsMark;
            this.chemMark = chemMark;
            this.mathMark = mathMark;

       }
        public void CalculatePer()
        {
            total = physicsMark + chemMark + mathMark;
            per=total/3;
        }
        public override string ToString()
        {
            return $"Student id is:{studentId} student name is: {studentName} Persentage is: {per} ";
        }

    }
}

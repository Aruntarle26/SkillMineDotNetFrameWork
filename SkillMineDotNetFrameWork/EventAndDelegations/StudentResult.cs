using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.EventAndDelegations
{
    public delegate void mydelr();
    public class Stud
    {
        public event mydelr pass;
        public event mydelr fail;
        public void Acceptmarks(int marks)
        {
            if(marks<=40)
            {
                fail();
            }
            else
            {
                pass();
            }
        }
    }
    
    
    public class Message
    {
        public static void Passmassage()
        {
            Console.WriteLine("great!  you are pass");
        }
        public static void Failmassage()
        {
            Console.WriteLine("sorry!  you are fail");
        }
    }
   public static class StudentResult
    {
       
       /* static void Main(string[] args)
        {
            Stud s1 = new Stud();
            s1.pass += new mydelr(Message.Passmassage);
            s1.fail += new mydelr(Message.Failmassage);
            s1.Acceptmarks(37);

        }*/

    }
}







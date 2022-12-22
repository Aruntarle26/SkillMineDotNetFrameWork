using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.DeleGate
{
    public delegate int mydile1(int x, int y);
    public delegate string mydile2(string z);
    class DelegateSimple
    {
        public int M1(int a, int b)
        {
            return a + b;
        }
        public string M2(string s)
        {
            return s;
        }
        /*static void Main(string[] args)
        {
            DelegateSimple d = new DelegateSimple();
            mydile1 d1 = new mydile1(d.M1);
            mydile2 d2 = new mydile2(d.M2);
           int sum= d1.Invoke(10, 20);
            string s2=d2.Invoke("hello");
            Console.WriteLine(sum);
            Console.WriteLine( s2 );



        }*/
    }
}

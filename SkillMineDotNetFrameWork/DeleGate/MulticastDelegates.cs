using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.DeleGate
{
    
    public delegate int mydile3(int x, int y);
    public delegate string mydile4(string z);
    class MulticastDelegates
    {
        public int M1(int a, int b)
        {
            return a + b;
        }
        public int M3(int a, int b)
        {
            return a * b;
        }
        public int M4(int a, int b)
        {
            return a / b;
        }
        public string M2(string s)
        {
            return s;
        }
        /*static void Main(string[] args)
        {
            MulticastDelegates d = new MulticastDelegates();
            mydile3 d1 = new mydile3(d.M1);
            d1 += new mydile3(d.M3);          //multi Delegates
            d1 += new mydile3(d.M4);
           Delegate[] a =d1.GetInvocationList();
            foreach( Delegate item in a)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(76,43));
            }
            mydile4 d2 = new mydile4(d.M2);//single delegates
            string s=d2.Invoke("bye");
            Console.WriteLine(s);






        }*/
    }
}

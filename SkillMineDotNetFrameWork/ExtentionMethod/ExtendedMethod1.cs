using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ExtentionMethod
{
    public static class ExtendedMethod1
    {
        public static void mul(this Calculator c1,int a, int b)
        {
            Console.WriteLine("Mul  is:" + (a * b));
        }
        public static void div(this Calculator c1,int a, int b)
        {
            Console.WriteLine("addition is:" + (a / b));
        }
        /*static void Main(string[] args)
        {
            Calculator c = new Calculator();
            

        }*/
    }
}

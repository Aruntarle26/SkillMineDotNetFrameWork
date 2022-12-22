using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ExceptionStudy
{
    
    class TryCatchStudy
    {
        public void Division(int a, int b)
        {
            // try
            // {
            int c = a / b;
            Console.WriteLine(c);
            //}
            //catch(DivideByZeroException d)
            // {
            //     Console.WriteLine(d.Message);
            //}

        }
        /*static void Main(string[] args)
        {

            int a = 20, b = 0;
            TryCatchStudy ex = new TryCatchStudy();
            try
            {
                ex.Division(a, b);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.GetType());
                Console.WriteLine(d.Message);
            }

        }*/
    }
}

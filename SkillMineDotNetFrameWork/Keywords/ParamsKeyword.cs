using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.Keywords
{
    class ParamsKeyword
    {
        public void add(params int []a)
        {
            int element = a.Length;
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine($"addition of {element} parameter is {sum}");

        }
    }
}

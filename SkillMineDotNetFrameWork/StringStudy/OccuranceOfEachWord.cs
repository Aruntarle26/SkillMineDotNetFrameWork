using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.StringStudy
{
    class OccuranceOfEachWord
    {
        public void OccuranceWord(string s)
        {
           string[] s2= s.Split(' ');
            for(int i=0;i<s2.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < s2.Length; j++)
                {
                    if(s2[i].Equals(s2[j]))
                    {
                        count++;
                        s2[j] = "0";
                    }

                }
                if(s2[i]!="0")
                Console.WriteLine(s2[i] + "  occures :" + count + " times");
            }

        }
       /* static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            OccuranceOfEachWord o = new OccuranceOfEachWord();
            o.OccuranceWord(s);

        }*/
    }
}

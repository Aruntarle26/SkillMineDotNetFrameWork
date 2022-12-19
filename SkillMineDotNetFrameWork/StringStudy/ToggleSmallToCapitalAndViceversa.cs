using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.StringStudy
{
    class ToggleSmallToCapitalAndViceversa
    {
        public void Togglechar(string s)
        {
            char[] ch = s.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]>='a' && ch[i]<='z')
                {
                   ch[i] = (char)(ch[i] - 32);
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
            }
          
            Console.WriteLine(string.Join("",ch));

        }
       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter the String ");
            string s = Console.ReadLine();
            ToggleSmallToCapitalAndViceversa t = new ToggleSmallToCapitalAndViceversa();
            t.Togglechar(s);

        }*/
    }
}

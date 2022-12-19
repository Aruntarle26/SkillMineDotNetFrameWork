using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.StringStudy
{
    class CheckPalindromString
    {
        public void PalindromCheck(string s)
        {
            //nayan
            bool flag = false;
            for(int i=0,j=s.Length-1;i<s.Length/2&&j>=s.Length/2;i++,j--)
            {
               if(s[i]==s[j])
                {
                    flag = true;
                }
            }
            if(flag==true)
            {
                Console.WriteLine("String is Palindrom...");
            }
            else
            {
                Console.WriteLine("String is Not Palindrom...");
            }

        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            CheckPalindromString c = new CheckPalindromString();
            c.PalindromCheck(s);
           

        }*/
    }
}

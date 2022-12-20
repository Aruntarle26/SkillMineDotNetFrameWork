using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.StringStudy
{
    class AnagramString
    {
        public void AnagramOrNot(string s1,string s2)
        {
            char[]a1=s1.ToCharArray();
            char[]a2=s2.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);
            string str1 = new string(a1);
            string str2 = new string(a2);
            if(str1==str2)
            {
                Console.WriteLine("Strings are anagram");
            }
            else 
                Console.WriteLine("Strings are anagram");


        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the First String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            string str2 = Console.ReadLine();
            AnagramString a = new AnagramString();
            a.AnagramOrNot(str1, str2);
        }*/
    }
}

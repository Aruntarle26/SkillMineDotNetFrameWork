using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ArrayMethod
{
    class PairElementSum
    {
        public void FindPair(int n,int[]a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for (int j = i+1; j< a.Length; j++)
                {
                    if((a[i]+a[j])==n)
                    {
                        Console.WriteLine("("+a[i] + "," + a[j]+")");
                    }
                }
            }

        }
        /*static void Main(string[]args)
        {
            int n = 7;
            int[] a = new int[] { 4, 5, 7, 1, 2, 3, 0 };
            PairElementSum p = new PairElementSum();
            p.FindPair(n, a);
        }*/
    }
}

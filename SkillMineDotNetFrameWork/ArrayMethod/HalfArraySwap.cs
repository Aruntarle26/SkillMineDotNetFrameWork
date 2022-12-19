using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ArrayMethod
{
    class HalfArraySwap
    {
        public void SwapHalfArray(int[]a)
        {
            /* int i = 0;
             int j = a.Length/2;
             int temp;
             while(j<a.Length)
             {
                 temp = a[i];
                 a[i] = a[j];
                 a[j] = temp;
                 i++;
                 j++;
             }*/
            int temp2;
           for(int i=0,j=a.Length/2;j<a.Length;j++,i++)
            {
                temp2 = a[i];
                a[i] = a[j];
                a[j] = temp2;
            }
            for(int z=0;z<a.Length;z++)
            {
                Console.Write(a[z] + " ");
            }

        }
       /* static void Main(string []args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            HalfArraySwap h = new HalfArraySwap();
            h.SwapHalfArray(a);
        }*/
    }
}

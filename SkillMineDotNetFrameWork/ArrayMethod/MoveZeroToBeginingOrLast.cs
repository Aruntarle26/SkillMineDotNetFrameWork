using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.ArrayMethod
{

    class MoveZeroToBeginingOrLast
    {
        public void ShiftZeroAtBeginning(int[]a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if(a[j]==0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }

            }
          
           for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void ShiftZeroAtlast(int[] a)
        {
            for (int i = a.Length-1; i >=1; i--)
            {
                for (int j = i -1; j >=0; j--)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }

            }

            Console.WriteLine(string.Join(" ",a));
           /* for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }*/
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };
            //Console.WriteLine(string.Format(" ", a));
            MoveZeroToBeginingOrLast m = new MoveZeroToBeginingOrLast();
            Console.WriteLine("shit zero at beginning----------- ");
            m.ShiftZeroAtBeginning(a);
            Console.WriteLine("shit zero at last----------- ");
            m.ShiftZeroAtlast(a);
        }*/
    }
}

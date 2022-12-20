using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.Array2D
{
    class MaxOfEachRow
    {
        public void MaxRow(int[,]a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i,j]>max)
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine((i+1) +" row max is: "+max);

            }


        }
        public void MaxColom(int[,] a)
        {

            for (int i = 0; i < a.GetLength(1); i++)
            {
                int max = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[j, i] > max)
                    {
                        max = a[j, i];
                    }
                }
                Console.WriteLine( (i+1)+" colom  max is: " + max);

            }


        }
        /*static void Main(string [] args)
        {
            int[,] a = new int[3,4];
            Console.WriteLine( "enter the array element...." );
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();

            }
            MaxOfEachRow m = new MaxOfEachRow();
            // m.MaxRow(a);
            m.MaxColom(a);
        }*/
    }
}

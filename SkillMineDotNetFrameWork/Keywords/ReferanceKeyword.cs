using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.Keywords
{
    class ReferanceKeyword
    {
        public void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.AbtractClassLearn
{
    public class Circle : Shape
    {
        double area;
        int radius;
        public void AccessRedius(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            area = (2 * 3.14) * radius;
           
        }
        public override string ToString()
        {
            return $"Area of Circle  is: {area}";
        }

    }
}

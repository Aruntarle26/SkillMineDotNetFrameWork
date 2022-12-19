using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.AbtractClassLearn
{
    public class Rectangle : Shape
    {
        double area;
        int lenght;
        int width;
        public void AccessLenghtAndWidth(int lenght,int width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public override void CalculateArea()
        {
            area = lenght*width;
            
        }
        public override string ToString()
        {
            return $"Area of Rectangle is: {area}";
        }

    }
}

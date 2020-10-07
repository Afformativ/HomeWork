using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Circle : Figure
    {
        public double r { get; private set; } = 0.0;
        public Circle(double R)
        {
            r = R;
           
        }
        public override double Area()
        {
           
            return Math.PI*r*r;
        }

        public override double Perimetr()
        {
            return 2*Math.PI*r;
        }
    }
}

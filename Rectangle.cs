using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Rectangle: Figure
    {
        public double a { get; private set; } = 0.0;
        public double b { get; private set; } = 0.0;
        public Rectangle(double A, double B)
        {
            a = A;
            b = B;
           
        }
        public override double Area()
        {

            return a * b;
        }

        public override double Perimetr()
        {
            return 2 * ( a + b );

        }
    }
}

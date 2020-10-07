using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Triangle : Figure
    {
        public double a { get; private set; } = 0.0;
        public double b { get; private set; } = 0.0;
        public double c { get; private set; } = 0.0;
        public Triangle(double A,double B,double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public override double Perimetr()
        {
            return a + b + c;
        }
    }
}

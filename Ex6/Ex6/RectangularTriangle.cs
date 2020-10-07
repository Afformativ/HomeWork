using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class RectangularTriangle : Triangle
    {
        public double a { get; private set; } = 0.0;
        public double b { get; private set; } = 0.0;
        public double alpha{ get; private set; } = 0.0;
        public RectangularTriangle(double A, double B, double Alpha)
        {
            a = A;
            b = B;
            alpha = Alpha;
        }
        public override double Area()
        {
            
            return Math.Sin(alpha * Math.PI / 180) *a*b/2;
        }

        public override double Perimetr()
        {
            return a+b+(Math.Sqrt(a*a+b*b-2*a*b*Math.Cos(alpha * Math.PI / 180)));
        }
    }
}

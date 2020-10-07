using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Rhombus : Figure
    {
        public double a { get; private set; } = 0.0;
        public double d1 { get; private set; } = 0.0;
        public double d2 { get; private set; } = 0.0;
        public Rhombus(double A, double D1, double D2)
        {
            a = A;
           d1 = D1;
           d2 = D2;
        }
        public override double Area()
        {
            
            return d1 * d2 / 2;
        }

        public override double Perimetr()
        {
            return 4 * a;
        }
    }
}

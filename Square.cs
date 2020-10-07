using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Square: Figure
    {
        public double a { get; private set; } = 0.0;
        
        public Square(double A)
        {
            a = A;
            
        }
        public override double Area()
        {
            
            return a * a;
        }

        public override double Perimetr()
        {
            return 4 * a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Triangle
    {
        public double Angles(double a, double b, double c)
        {
            double A;
            A = (b * b + c * c - a * a) / (2 * b * c);
            return Math.Acos(A);
        }
        public double Perimetr(double a, double b, double c)
        {
            return a + b + c;
        }
        public bool Proverka(double a, double b, double c)
        {
            if(a<= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            else if (a >= b + c || b >= a + c || c >= a + b)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
    class EquilateralTriange : Triangle
    {
        public double Area(double a, double b, double c)
        {
            return Math.Sqrt(3*a*a*a*a/16);
        }
    }
}

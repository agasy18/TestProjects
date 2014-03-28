using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA6
{
    public class SquareEquation
    {
        public static bool Calc(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;
            if (a == 0)
                return false;

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                return false;
            }

            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            return true;
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            SquareEquation.Calc(1, 0, 9, out x1, out x2);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

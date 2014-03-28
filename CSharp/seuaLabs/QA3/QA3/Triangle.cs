using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA3
{
    public class Triangle
    {
        int a;
        int b;
        int c;

        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                throw new InvalidOperationException();
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsHavasarakoxm
        {
            get
            {
                return a == b && a == c && b == c;
            }
        }

        public bool IsHavasarasrun
        {
            get
            {
                return (a == b || a == c || b == c);
            }
        }

    }
}

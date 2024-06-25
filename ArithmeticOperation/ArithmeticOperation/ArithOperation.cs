using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryArithmetic
{
    public class ArithOperation
    {
        public int? square(int? a)
        {
            if (a == null)
            {
                return null;
            }
            return a * a;
        }
        public int? cube(int? a)
        {
            if (a == null)
            {
                return null;
            }

            return (a * a * a);
        }
        public double? divide(double? a, double? b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            double? c = a / b;
            return c;
        }

    }
}

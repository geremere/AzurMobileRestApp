using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguleLibrary
{
    public class RightTrianglar : Triangle
    {

        public RightTrianglar(double a, double b):base(a,b,Math.Sqrt(a*a+b*b))
        {
            A = a;
            B = b;
        }


        public override double Square()
        {
            double s;
            try
            {
                s = A * B / 2;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            return s;
        }
        public override double Perimetr()
        {
            return A+B+Math.Sqrt(A*A+B*B);
        }
        public override double MaxHeight()
        {
            return Math.Max(A,B);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguleLibrary
{
    public class EqualitionTriangle:Triangle
    {
        public EqualitionTriangle(double c):base(c,c,c)
        {
            C = c;
        }

        public override double MaxHeight()
        {

            double s;
            try
            {
                s = C*C*Math.Sin(Math.PI/3);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            return s;
        }

        public override double Perimetr()
        {
            return 3 * C;
        }

        public override double Square()
        {
            double h;
            try
            {
                h = C * Math.Sin(Math.PI / 3);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            return h;
        }

        public double Resize(int k)
        {
            B = B * k;
            A = A * k;
            return C = C * k;
        }
    }
}

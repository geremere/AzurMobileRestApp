using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plane
{
    public class Rectancular
    {
        public Rectancular(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

         private double x1;
         private double y1;
        public double X1 { get { return x1; } }
        public double Y1 { get { return y1; } }


        private double x2;
        private double y2;
        public double X2 { get { return x2; } }
        public double Y2 { get { return y2; } }


        public virtual double S { get { return (x1 - x2) * (y2-y1); } }
        public virtual double P { get { return ((x1 - x2) + (y2 - y1))*2; } }

        public override String ToString()
        {
            return $"LeftHight={x1:f2},{y1:f2}\n" +
                $"RightLow={x2:f2},{y2:f2}\n" +
                $"S={S:f2}\n" +
                $"P={P:f2}";
        }

    }
     public class Square:Rectancular
    {
        public Square(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {
        }

        public override double S { get { return (X1 - X2) * (X1 - X2); } }
        public override double P { get { return (X1 - X2)*4; } }

        public override String ToString()
        {
            return $"LeftHight={X1:f2},{Y1:f2}\n" +
                $"RightLow={X2:f2},{Y2:f2}\n" +
                $"S={S:f2}\n" +
                $"P={P:f2}";
        }
    }
}

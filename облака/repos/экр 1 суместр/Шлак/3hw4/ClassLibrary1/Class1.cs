using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }

    class Geometry
    {
        public static double GetLenght()
        {
            Vector vv = new Vector();

            return Math.Sqrt(vv.X * vv.X + vv.Y * vv.Y);
        }

        public static double Add()
        {
            Vector vv = new Vector();
            Vector v = new Vector();
            return v.X+vv.Y;
        }

        class Segment
        {
            public Vector being;
            public Vector end;

            public Geometry.GetLength()
            {

            }
        }

    }
}

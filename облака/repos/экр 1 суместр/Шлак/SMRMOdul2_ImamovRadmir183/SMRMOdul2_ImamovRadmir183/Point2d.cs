using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMRMOdul2_ImamovRadmir183
{
    class Point2d
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point2d(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public double Dictance(Point2d other)
        {
            return Math.Sqrt((X - other.X)*(X - other.X) + (Y - other.Y)*(Y - other.Y));
        }

       public Point2d this[int n]
        {
            get
            {
                Point2d dot = new Point2d(Math.Pow(this.X, n), Math.Pow(this.Y, n));

                return dot;
            }
        }

        public Point2d Closer(Point2d a, Point2d b)
        {
            double distance1 = Math.Sqrt((X - a.X)*(X - a.X) + (Y - a.Y)*(Y - a.Y));
            double distance2 = Math.Sqrt((X - b.X)*(X - b.X) + (Y - b.Y)*(Y - b.Y));
            if (distance1 > distance2)
                return a;
            else
                return b;
        }
    }
}

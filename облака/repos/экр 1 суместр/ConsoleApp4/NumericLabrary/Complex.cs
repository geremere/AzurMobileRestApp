using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLabrary
{
    public class Complex : Pair
    {
        public Complex(int x, int y) : base(x, y)
        {
        }

        public override Pair Add(Pair b)
        {
            X= X + b.X;
            Y = Y + b.Y;
            return new Complex(X, Y);
        }

        public override int Equal(Pair b)
        {

            if ((X == b.X) && (Y == b.Y)) return 0;
            else return -1;
        }

        public override Pair Mult(Pair b)
        {
            int X1 = X;
            X = X * b.X - Y * b.Y;
            Y = X1 * b.Y + Y * b.X;
            return new Complex(X, Y);
        }

        public override Pair Sub(Pair b)
        {
            X = X - b.X;
            Y = Y - b.Y;
            return new Complex(X, Y);
        }

        public override string ToString()
        {
            return $"{X}+{Y}i";
        }
    }
}

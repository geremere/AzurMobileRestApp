using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLabrary
{
    public class Rational : Pair
    {
        public Rational(int x, int y):base(x,y)
        {
                if (Y <= 0) throw new ArgumentNullException();
        }


        public override Pair Add(Pair b)
        {
            X = X * b.Y + Y * b.X;
            Y = Y * b.Y;
            return new Rational(X, Y);
        }

        public override int Equal(Pair b)
        {
            if (X * b.Y == b.X * Y) return 0;
            if ((X * b.Y - Y * b.X) > 0) return 1;
            else return -1;
        }

        public override Pair Mult(Pair b)
        {
            X = X * b.X;
            Y = Y * b.Y;
            return new Rational(X, Y);
        }

        public override Pair Sub(Pair b)
        {
            X = X * b.Y - Y * b.X;
            Y = Y * b.Y;
            return new Rational(X, Y);
        }

        public override string ToString()
        {
            return $"{X}/{Y}";
        }
    }
}

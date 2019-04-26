using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrTest
{
    abstract public class Pair
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }

            private set
            {
                x = value;
            }

        }//свойство
        
        public int Y { get; private set; }//на самом деле set уже приватный но это так что я типо шарю

        public Pair(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract Pair Add(Pair b);

        public abstract Pair Sub(Pair b);

        public abstract Pair Mult(Pair b);

        public int PairEqual(Pair b)
        {
            if (b.X == X)
            {
                if (b.Y == Y)
                {
                    return 0;
                }

                if(b.Y>Y)
                {
                    return -1;
                }

                if(b.Y<Y)
                {
                    return 1;
                }
            }

            if(b.X>X)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }

    public class Complex:Pair
    {
        int x, y,a,b;

        public Complex(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public override Pair Add(Pair z)
        {
            a= z.X + X;
            b = z.Y + Y;
            x = a;
            y = b;
            Complex add = new Complex(x, y);
            return add;
        }

        public override Pair Sub(Pair z)
        {
            a = X - z.X;
            b = Y - z.Y;
            x = a;
            y = b;
            Complex sub = new Complex(x, y);
            return sub;
        }

        public override Pair Mult(Pair z)
        {
            a = z.X*X-z.Y*Y;
            b = z.X*Y+z.Y*X;
            x = a;
            y = b;
            Complex mult = new Complex(x, y);
            return mult;
        }

        public override string ToString()
        {
            return $"{x}+{y}i";
        }
    }
}

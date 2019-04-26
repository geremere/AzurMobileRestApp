using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLabrary
{
    public abstract class Pair
    {
        private int x;
        public int X
        {
            get => x;
            protected set
            {
                x = value;
            }
        }
        public int Y { get; protected set; }
        protected Pair(int x, int y)
        {
            this.x = x;
            Y = y;
        }
        public abstract Pair Add(Pair b);
        public abstract Pair Sub(Pair b);
        public abstract Pair Mult(Pair b);
        public abstract int Equal(Pair b);

        public override string ToString()
        {
            return $"X={X} Y={Y}";
        }
    }
}

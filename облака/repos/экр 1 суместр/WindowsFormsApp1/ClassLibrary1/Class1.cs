using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  abstract class Property
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (a > 1) throw new PropertyExceptinon();
                a = value;
            }
        }
        private double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (a < 1) throw new PropertyExceptinon();
                b = value;
            }
        }
        private int c;

        protected Property(double a, double b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                checked
                {
                    c = value;
                }
            }
        }

        public abstract double this[int x] { get; }

        public override string ToString()
        {
            return $"a: {A}\t" +
                $"b: {B}\t" +
                $"c: {C}\t";
        }

    }
}

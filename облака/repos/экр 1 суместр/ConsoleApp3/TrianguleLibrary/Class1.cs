using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguleLibrary
{
    public abstract class Triangle
    {
        private double a;
        private double b;
        private double c;

        protected Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double P { get { return (a + b + c) / 2; } }

        public double A
        {
            get
            {
                return a;
            }
            protected set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            protected set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            protected set
            {
                c = value;
            }
        }

        public abstract double Square();
        public abstract double Perimetr();
        public abstract double MaxHeight();

        public override string ToString()
        {
            return $"A= {A:f3}\n" +
                $"B= {B:f3}\n" +
                $"C= {C:f3}\n" +
                $"Square= {Square():f3}\n" +
                $"Perimetr= {Perimetr():f3}\n" +
                $"MaxHeight= {MaxHeight():f3}\n";
        }

    }
}

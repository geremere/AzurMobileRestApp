using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLib
{
    public class Parabola : Function
    {
        public Parabola(string name, double b, double c, double a) : base(name, b, c, a)
        {
        }

        public override double this[double x]
        {
            get
            {
                checked
                {
                    return A * x * x + B * x + C;
                }
            }
        }

        public override double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public override double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Parabola: {A}x^2+{B}x+{C}";
        }
    }
}

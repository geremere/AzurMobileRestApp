using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLib
{
    public class Parabola : Function
    {
        public Parabola(string name, int a, int b, int c) : base(name, a, b, c)
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

        public override string ToString()
        {
            return $"{base.ToString()}\n View: {A}x^2+{B}x+{C}";
        }
    }
}

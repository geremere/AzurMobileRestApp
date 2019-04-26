using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLib
{
    public class Hyperbola : Function
    {
        public Hyperbola(string name, int a, int b, int c) : base(name, a, b, c)
        {
        }

        public override double this[double x]
        {
            get
            {
                if (B * x + C == 0) throw new FunctionLibArgumentException();
                checked
                {
                    return A / B * x + C;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n View: {A}/{B}x+{C}";
        }
    }
}

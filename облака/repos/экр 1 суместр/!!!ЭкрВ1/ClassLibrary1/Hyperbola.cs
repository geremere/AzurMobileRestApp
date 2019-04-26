using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLib
{
    public class Hyperbola : Function
    {
        public Hyperbola(string name, double b, double c, double a) : base(name, b, c, a)
        {
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
        public override double this[double x]
        {
            get
            {
                if ((x * B + C) == 0) throw new ArgumentException();
                checked
                {
                    return A / (B * x + C);
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n Hyperbola: {A}/{B}x+{C}";
        }

    }
}


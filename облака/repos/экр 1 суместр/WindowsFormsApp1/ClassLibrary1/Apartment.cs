using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Apartment : Property
    {
        public Apartment(double a, double b, int c) : base(a, b, c)
        {
        }

        public override double this[int x]
        {
            get
            {
                //if (C == x) throw new DivideByZeroException();
                return A * B / (C - x);
            }
        }

        public override string ToString()
        {
            return $"Apartmnet\t" +
                $"{base.ToString()}\n";
        }
    }
}

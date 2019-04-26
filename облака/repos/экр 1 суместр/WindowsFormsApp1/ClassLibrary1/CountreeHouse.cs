using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CountreeHouse : Property
    {
        public CountreeHouse(double a, double b, int c) : base(a, b, c)
        {
        }

        public override double this[int x]
        {
            get
            {
                //if (B == x) throw new DivideByZeroException();
                return A * C / (B - x);
            }
        }
        public override string ToString()
        {
            return $"CountreeHouse\t" +
                $"{base.ToString()}\n";
        }
    }
}

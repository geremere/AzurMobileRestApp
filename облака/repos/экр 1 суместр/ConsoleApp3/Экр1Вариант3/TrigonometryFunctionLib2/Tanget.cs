using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometryFunctionLib2
{
    public class Tanget:Function
    {
        public Tanget(string name, double b, double a, double c) : base(name, b, a, c)
        {
        }

        public override double this[double x]
        {
            get
            {
                if ((B * x) % 180 == 90) throw new ArgumentException("аргумент не равен П/2 + 2Пn ");
                return A * Math.Tan(B * x * Math.PI / 180) + C;
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

        public override string ToString()
        {
            return $"Вид: {A:f3}tg({B:f3}x) + {C:f3}.\n" + base.ToString();
        }
    }
}

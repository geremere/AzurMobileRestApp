using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ср
{
    public class Circle
    {
        public Circle(double centre, double r)
        {
            this.centre = centre;
            R = r;
        }

        public double centre { get; private set; }
        public double R { get; private set; }

        public override string ToString() => $"RADIUS= {R},\nCentre= {centre}\n";
    }
}

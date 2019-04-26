using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvp2
{
    class ColoredCircle
    {
        double radius=1.0;
        string color="black";
        public void Li() { }
        public void op(double color) { }
        public double Square
        {
            get { 
            return radius*radius*Math.PI; }
        }
        public static double Radius()
        {
            return 1.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ColoredCircle col = new ColoredCircle();
            Console.WriteLine("square= {0}",col.Square);

        }
    }
}

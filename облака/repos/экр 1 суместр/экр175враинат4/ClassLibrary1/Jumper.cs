using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jumper : Athlete
    {
        double distance;

        public Jumper(string name, double distance) : base(name)
        {
            this.distance = distance;
        }

        public double Distace
        {
            get
            {
                return distance;
            }
        }


        public override bool IsOnDoping()
        {
            if (distance > 8.9) return true;
            else return false;  
        }

        public override string ToString()
        {
            return $"Name: {name}\tDistance: {distance:f3}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Runner : Athlete
    {
        int distance;
        double time;

        public Runner(string name, double time) : base(name)
        {
            distance = 100;
            this.time = time;
        }

        public double Speed { get { return distance / time; } }


        public override bool IsOnDoping()
        {
            if (Speed > 12.42) return true;
            else return false;
        }

        public override string ToString()
        {
            return $"Name: {name}\tDistance: {distance}\tTime: {time:f3}\tSpeed: {Speed:f3}";
        }
    }
}

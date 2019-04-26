using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Вриант4
{
    public class CargoWagon : Wagon
    {
        public CargoWagon(int mass, int MaxCapacity, int Capacity) : base(mass, MaxCapacity, Capacity)
        {
        }

        public override int Mass
        {
            get
            {
                return mass + Capacity;
            }
        }

    }
}

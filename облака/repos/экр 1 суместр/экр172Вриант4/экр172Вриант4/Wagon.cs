using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Вриант4
{
    public class Wagon : TrainPart
    {
        int MaxCapacity;
        protected int Capacity { get; private set; }
        public Wagon(int mass, int MaxCapacity, int Capacity) : base(mass)
        {
            this.MaxCapacity = MaxCapacity;
            this.Capacity = Capacity;
        }

        private void Fill(int amount)
        {
            if (amount > MaxCapacity) throw new ArgumentException();
            Capacity = amount;
        }
        public override int Mass => throw new NotImplementedException();
    }
}

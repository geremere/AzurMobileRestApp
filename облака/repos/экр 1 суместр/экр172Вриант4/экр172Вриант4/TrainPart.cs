using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Вриант4
{
    public abstract class TrainPart
    {
        protected int mass;

        public Wagon next;

        protected TrainPart(int mass)
        {
            this.mass = mass;
        }

        public virtual void Connect(Wagon another) { }
        public abstract int Mass { get; }


    }
}

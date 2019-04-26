using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Вриант4
{
    public class Train : TrainPart
    {
        int power;
        int sumMass;
        Random rnd = new Random();
        public Train(int mass,int power) :base(mass)
        {
            this.power = power;
            sumMass = 0;
        }

        public override int Mass
        {
            get
            {
                return sumMass;
            }
        }

        public override void Connect(Wagon another)
        {
            
            while(another!=null)
            {
                if (sumMass + another.Mass <= power)
                {
                    sumMass += another.Mass;
                    if (rnd.Next(0, 2) == 1)
                    {
                        Connect(new CargoWagon(mass, rnd.Next(20, 36), rnd.Next(2, 10)));
                    }
                    else
                    {
                        Connect(new PassengerWagon(mass, rnd.Next(20, 36), rnd.Next(2, 10)));
                    }
                }
                else another = null;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ralli
{
    public class SpeedCar : Car
    {
        public SpeedCar(string name)
        {
            Name = name;
        }

        public override char Symbol
        {
            get
            {
                return '>';
            }
        }

        public override void Step()
        {
            X += rnd.Next(3, 6);
        }


    }
}

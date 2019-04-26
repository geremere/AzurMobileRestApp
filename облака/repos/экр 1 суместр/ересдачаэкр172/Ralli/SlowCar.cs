using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ralli
{
    public class SlowCar : Car
    {
        public SlowCar(string name)
        {
            Name = name;
        }

        public override char Symbol
        {
            get
            {
                return 'o';
            }
        }
        public override void Step()
        {
            X += rnd.Next(0, 3);
        }
    }
}

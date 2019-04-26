using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Class1
    {
        private int x;

        public Class1(int x)
        {
            this.x = x;
        }

        public double this[int x1]
        {
            get
            {
                return 1 * 5 / (x1-x);
            }
        }
    }
}

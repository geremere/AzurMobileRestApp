using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran
{
    public class Sushi : Food
    {
        public override int CaloricValue
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return $"CaloricValue:{CaloricValue}";
        }
    }
}

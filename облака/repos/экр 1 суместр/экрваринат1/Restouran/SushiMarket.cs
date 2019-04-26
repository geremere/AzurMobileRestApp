using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran
{
    public class SushiMarket : Cook
    {
        public SushiMarket(string name) : base(name)
        {
        }

        public override Food Prepare()
        {
            throw new NotImplementedException();
        }
    }
}

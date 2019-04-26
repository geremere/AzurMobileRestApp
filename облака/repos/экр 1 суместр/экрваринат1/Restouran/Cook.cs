using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran
{
    public abstract class Cook
    {
        public abstract Food Prepare();
        string name;

        protected Cook(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}

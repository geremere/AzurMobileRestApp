using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Item
    {
        public string name { get; private set; }
        double price;

        protected Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double Price
        {
            get
            {
                if (price < 0) throw new ArgumentException();
                return price;
            }
        }


    }
}

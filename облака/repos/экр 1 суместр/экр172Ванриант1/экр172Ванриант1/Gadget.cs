using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Ванриант1
{
    public abstract class Gadget
    {
        int price;
        public int Price { get { return price; } }
        string manufacturer;
        public string Manufacturer { get { return manufacturer; } }
        protected Gadget(int price, string manufacturer)
        {
            this.price = price;
            this.manufacturer = manufacturer;
        }

    }
}

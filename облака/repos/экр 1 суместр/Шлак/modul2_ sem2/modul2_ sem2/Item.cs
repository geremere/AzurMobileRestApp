using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2__sem2
{
    class Item
    {
        public string name { get; }
        public uint price { get; }
        public uint quantity { get; }

        public Item(string name, uint price, uint quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

    
        public override string ToString()
        {
            return $"{name}\t{price}\t{quantity}\t{price*quantity}";
        }
    }
}

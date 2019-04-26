using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Drink:Item
    {
        public Drink(string name, double price, int volume) : base(name, price)
        {
            Volume = volume;
        }

        public int Volume { get; }

        public override string ToString()
        {
            return $"Name: {name}, Price: {Price:f2}, Weight: {Volume}мл";
        }

    }
}

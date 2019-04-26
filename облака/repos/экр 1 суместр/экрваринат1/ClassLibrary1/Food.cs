using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Food : Item
    {
        public int Weight { get; }
        public Food(string name, double price,int weight) : base(name, price)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {name}, Price: {Price:f2}, Weight: {Weight}гр";
        }
    }
}

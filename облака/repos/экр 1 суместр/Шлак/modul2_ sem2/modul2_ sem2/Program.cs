using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2__sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("банан",30,10);
            Item item1 = new Item("банан", 30, 10);
            ShoppingChart sc = new ShoppingChart();
            sc.AddToCart(item);
            sc.AddToCart(item1);
            Console.WriteLine(sc);
            Console.Read();
        }
    }
}

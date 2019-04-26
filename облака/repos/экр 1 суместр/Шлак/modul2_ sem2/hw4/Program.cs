using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Square sq = new Square(5);
                Console.WriteLine("to exit escape!");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

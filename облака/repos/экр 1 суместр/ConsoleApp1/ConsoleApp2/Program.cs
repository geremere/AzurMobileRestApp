using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.12345678911111111111;
            double b = 0.12345678911111111110;
            Console.WriteLine(a == b);
            Console.WriteLine(a.CompareTo(b));
            Console.Read();
        }
    }
}

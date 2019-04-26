using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double p = 1;
            double sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                p = 1;
                for (int j = 1; j <= 5; j++)
                {
                    p *= i * x / j;
                }
                sum += p;
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}

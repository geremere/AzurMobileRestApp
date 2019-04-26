using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    class Program
    {
        public static int reading()
        {
            string line;
            int res;
            do
            {
                Console.WriteLine("vvedi x:");
                line = Console.ReadLine();
            } while (!int.TryParse(line, out res));
            return res;
        }
        static void Main()
        {
            ConsoleKeyInfo K;
            do
            {
                int x = reading();
                int fact = 1, n = 0, step = 1;
                double sum = 0, s = 0;
                do
                {
                    s = (double)(Math.Pow(x, n)*fact);
                    sum += s;
                    step++;
                    n++;
                    fact = 1;
                } while (s > double.Epsilon);
                Console.WriteLine(sum);
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

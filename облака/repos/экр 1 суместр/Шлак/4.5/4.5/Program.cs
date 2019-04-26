using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
    {
        public static uint reading()
        {
            string line;
            uint result;
            do
            {
                Console.WriteLine("введите целое неотрицательное число К");
                line = Console.ReadLine();
                if (!uint.TryParse(line, out result))    Console.WriteLine("ошибка ввода");
            } while (!uint.TryParse(line, out result));
            return result;
        }
        public static double recurs(ref uint value)
        {
            double sum = 0;
            for (int i=1;i<(value+1);i++)
            {
                double q1=i+0.3;
                double q2 = 3 * i * i + 5;
                sum +=q1/q2;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                uint value = reading();
                double result = recurs(ref value);
                Console.WriteLine(result);
                Console.WriteLine("для выхода из программы нажмите escape");
                K = Console.ReadKey();
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

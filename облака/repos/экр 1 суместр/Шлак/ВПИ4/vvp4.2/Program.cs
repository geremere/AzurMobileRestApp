using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvp4._2
{
    class Program
    {
        public static uint reading(string text)
        {
            string line;
            uint res;
            do
            {
                Console.WriteLine("{0}", text);
                line = Console.ReadLine();

                if ((!uint.TryParse(line, out res)) || (res == 0))
                    Console.WriteLine("ошибка ввода");

            } while ((!uint.TryParse(line, out res)) || (res == 0));
            return res;
        }
        public static void ArrayCreater(ref double[] ar)
        {
            ar[0] = 1;
            for (int i = 1; i < ar.Length-1; i++)
            {
                ar[i] =(double) 1 / (i+1);
            }
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n = reading("введите длину массива");
                double[] ar = new double[n];
                ArrayCreater(ref ar);
                for (int i = 0; i < ar.Length-1; i++)
                {
                    Console.Write($"{ar[i]:f4}  ");
                }
                Console.WriteLine("");
                Console.WriteLine("escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}
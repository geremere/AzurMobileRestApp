using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvp4._3
{
    class Program
    {
        public static uint Reading(string text)
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();

                if (!uint.TryParse(line, out res))
                    Console.WriteLine("ошибка ввода");

            } while (!uint.TryParse(line, out res));
            return res;
        }
        public static void ArrayCreater(ref uint[] ar, uint a,uint b)
        {
            ar[0] = a;
            ar[1] = b;
            Console.Write($"{ar[0]}  {ar[1]}  ");
            uint sum = a + b;
            for (int i=2;i<ar.Length;i++)
            {
                ar[i] = sum;
                sum += ar[i];
                Console.Write(ar[i]);
                Console.Write(" ");
            }

        }
            static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n;
                uint a = Reading("A");
                uint b = Reading("B");

                do
                {
                    n = Reading("N");
                    if (n <= 2) Console.WriteLine("ошибка ввода");
                } while (n <= 2);

                uint[] ar = new uint[n];
                ArrayCreater(ref ar, a, b);
                Console.WriteLine();
                Console.WriteLine("для выхода из порграммы нажмите escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

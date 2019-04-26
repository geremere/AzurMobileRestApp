using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        public static uint Read(string text)
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}", text);
                line = Console.ReadLine();
                if ((!uint.TryParse(line, out res)) || (res <= 1))
                    Console.WriteLine("ошибка ввода!");
            } while ((!uint.TryParse(line, out res)) || (res<=1));
            return res;
        }
        public static void ArrayFib(uint[] fib)
        {
            fib[0] = 1;
            Console.Write("A[{0}]={1} ", 0, fib[0]);
            fib[1] = 1;
            Console.Write("A[{0}]={1} ", 1, fib[1]);

            for (uint i=2;i<fib.Length;++i)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
                Console.Write("A[{0}]={1} ", i, fib[i]);
            }
            Console.WriteLine();

        }
        public static void ReversArrayFib(uint[] fib)
        {
            for (uint i=0;i<fib.Length;++i)
            {
                for (uint j=0;j<(fib.Length-1-i);++j)
                {
                    if (fib[j]<fib[j+1])
                    {
                        fib[j] = fib[j] + fib[j + 1];
                        fib[j + 1] = fib[j] - fib[j + 1];
                        fib[j] = fib[j] - fib[j + 1];
                    }
                }
            }
        }
        public static void PrintArray(uint[] fib)
        {
            for (uint i=0;i<fib.Length;++i)
            {
                Console.Write("A[{0}]={1} ", fib.Length-1-i, fib[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n = Read("введите целое число больше единицы: ");
                uint[] fib = new uint[n];
                ArrayFib(fib);
                ReversArrayFib(fib);
                PrintArray(fib);
                Console.WriteLine("to exit Escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

using System;

namespace ильшатка
{
    class Program
    {
        /// <summary>
        /// метод ввода числа n
        /// </summary>
        /// <returns> число n</returns>
        public static uint READ()
        {
            string line;
            uint res;
            do
            {
                Console.Write("введите N: ");
                line = Console.ReadLine();
            } while ((!uint.TryParse(line, out res)) || (res < 1)) ;
            return res;
        }
        public static double Creator(uint n)
        {
            double res;
            uint i=0;
            do
            {
                i++;
                res = Math.Pow(-1, i + 1) / (i * (i + 1)*(i + 2));

            } while (i != n);
            return res;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n = READ();
                double sum = Creator(n);
                Console.WriteLine("сумма последовательности: " + sum);
                Console.WriteLine("to exist escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

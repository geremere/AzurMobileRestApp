using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        public static double reading()
        {
            double text;
            string line;
            do
            {
                Console.WriteLine("введите целочисленое значение стороны треугобьника");
                line = Console.ReadLine();
            } while (!double.TryParse(line, out text));
            return text;
        }
        public static bool triangule(ref double a, ref double b, ref double c, out double S, out double P)
        {
            bool result;
            if ((a+b<=c)||(a+c<=b)||(c+b<=a))
            {
                S = 0;
                P = 0;
                return result = false;
            }
            else
            {
                P = a + b + c;
                S = Math.Sqrt((P / 2) * ((P /  2) - a)*((P / 2) - b)*((P / 2) - c));
                return result = true;
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                double a = reading();
                double b = reading();
                double c = reading();
                double P, S;
                bool logic = triangule(ref a, ref b, ref c, out S, out P);
                Console.WriteLine(logic);
                if (logic)
                {
                    Console.WriteLine(S);
                    Console.WriteLine(P);
                }
                    Console.WriteLine("для выхода из ирограмммы нажмите Escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

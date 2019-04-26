using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        public static int A(string number)
        {
            string reading;
            int result;
            do
            {
                Console.WriteLine("Введите {0}:", number);
                reading = Console.ReadLine();
                if (!int.TryParse(reading, out result)) Console.WriteLine("ошибка ввода");
            }
            while (!int.TryParse(reading, out result));
            return result;
        }
         static bool Newton(double x, out double sq, out double eps)
        {
            double r1, r2 = 1000;
            sq = eps = 0.0;
            if (x<=0.0){
                Console.WriteLine("eror");
                return false;
            }
            do
            {
                r1 = r2;
                eps = x / r1 / 2 - r1 / 2;
                r2 = r1 + eps;

            } while (r1 != r2);
            sq = r2;
            return true;
        }

        static void Main()
        {
            ConsoleKeyInfo K;
            do
            {
                double x, result = 0, eps = 0,sq;
                x = A("число х");
                bool summ = Newton(x,out sq, out eps);
                if (!Newton(x, out result, out eps))
                {
                    Console.WriteLine("eror!");
                }
                Console.WriteLine("root({0})={1},eps={2}",x,result,eps);
                Console.WriteLine("Для выхода из программы нажмите ESCAPE");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

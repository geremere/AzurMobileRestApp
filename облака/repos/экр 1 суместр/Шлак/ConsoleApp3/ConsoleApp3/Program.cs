using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static int reading(string text)
        {
            string line;
            int result;
            do
            {
                Console.WriteLine("введите {0}", text);
                line = Console.ReadLine();
                if ((!int.TryParse(line, out result))||((result < 100) ||(result >= 1000))) Console.WriteLine("ошибка ввода");
            } while ((!int.TryParse(line, out result))||((result < 100)||(result >= 1000)));
            return result;
        }
        public static int resenie(int A, int B)
        {
            if (A>B)
            {
                int K = A;
                A = B;
                B = K;
            }
            int shet = 0;
            while (A!=B)
            {
                if ((A % 5 == 0) && (A % 11 == 0)) shet++;
                A++;
            }
            return shet;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                int A = reading("левую границу");
                int B = reading("правую границу");
                int result = resenie(A, B);
                Console.WriteLine(result);
                Console.WriteLine("Для выхода из программы нажмите Escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
            Console.Beep(400, 400);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace впи2
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
                if (!int.TryParse(line, out result))  Console.WriteLine("ошибка ввода");
            } while (!int.TryParse(line, out result));
            return result;
        }
        public static int SummIt(int A, int B)
        {
            if (A > B)
            {
                int K = A;
                A = B;
                B = K;
            }
            int shet = 0;
            do
            {
                string str = A.ToString();
                str.IndexOf('1');
                if (str.IndexOf('1') >= 0) shet += A;

            } while (A++ != B);
            return shet;
        }
        public static int TOTALSumm(int A, int B)
        {
            if (A > B)
            {
                int K = A;
                A = B;
                B = K;
            }
            int shet = 0;
            do
            {
                shet += A;
            } while (A++ != B);
            return shet;
        }

            static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                int A = reading("левую границу");
                int B = reading("правую границу");
                int result = SummIt(A, B);
                int result2 = TOTALSumm(A, B);
                Console.WriteLine(result);
                Console.WriteLine(result2);
                Console.WriteLine("Для выхода из программы нажмите Escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

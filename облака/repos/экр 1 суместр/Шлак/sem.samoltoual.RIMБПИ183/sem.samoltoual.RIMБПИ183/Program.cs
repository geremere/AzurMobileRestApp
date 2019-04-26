using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem.samoltoual.RIMБПИ183
{
    class Program
    {
        /*
         * Имамов Радмир Маратович
         * Бпи183(2)
         * варинат3
         * 9.10.2018
         */
         public static int reading( string k)
        {
            string line;
           int text;
            do
            {
                Console.WriteLine("введите целое неотрицательное число{0}", k);
                line = Console.ReadLine();
                if ((!int.TryParse(line, out text))||!(text>=0)) Console.WriteLine("ошибка ввода");
            } while ((!int.TryParse(line, out text))||!(text>=0));
            return text;
        }
        public static void fib (ref int a,ref int b)
        {
            int i = 0,fibon=0,j=0;
            do
            {
                fibon = i + j;
                if (fibon == 0) fibon = 1;
                j = i;
                i++;
                if ((i>a)&&(i%2==0))
                {
                    Console.Write("{0} ",fibon);
                }
            } while (i != b);
        }

         
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                int a = reading("а");
                int b = reading("b");
                if (a>b)
            {
               int k = b;
                b = a;
                a = k;
            }
                fib(ref a, ref b);
                Console.WriteLine("");
                Console.WriteLine("для выхода из программы введите escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

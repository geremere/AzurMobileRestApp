using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача8
{
    class Program
    {
        /// <summary>
        /// метод для ввода перменных
        /// </summary>
        /// <param name="text"></param>
        /// <returns>выводит переменную</returns>
        public static int READ(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res)) || (res <= 0)) Console.WriteLine("eror");
            } while ((!int.TryParse(line, out res)) || (res <= 0));
            return res;
        }
        public static void PRint(int n,int[][]matr)
        {
            int leng;
            leng = matr[0].Length;
            for (uint i=1;i<matr.Length;++i)
            {
                if (matr[i].Length > leng) leng = matr[i].Length;
            }
            Console.WriteLine("наибольшая длинна строки: {0}", leng);
            int sum=0;
            for (uint i=0;i<matr[0].Length;i++)
            {
                sum += matr[0][i]; 
            }
            for (uint i=1;i<n;++i)
            {
                int sum2 = 0;
                for (uint j=0;j<matr[i].Length;++j)
                {
                    sum2 += matr[i][j];
                }
                if (sum2 > sum) sum = sum2;
            }
            Console.WriteLine("наибольшая сумма строки: {0}", sum);
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                int n = READ("введите положительно число n");
                int m = READ("введите положительное число m");
                int[][] matr;
                matr = new int[n][];
                Random rnd = new Random();
                for (uint i = 0; i < matr.Length; ++i)
                {
                    matr[i] = new int[rnd.Next(m)];
                    for (uint j = 0; j < matr[i].Length; ++j)
                    {
                        matr[i][j] = rnd.Next(0, 100);
                        Console.Write("{0,4}", matr[i][j]);
                    }
                    Console.WriteLine();
                }
                PRint(n, matr);
                Console.WriteLine("to exist escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

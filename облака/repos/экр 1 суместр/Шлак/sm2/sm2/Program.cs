using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Имамов Радмир Маратович
 Варинат: 
 06.11.2018
 */
namespace sm2
{
    class Program
    {
        /// <summary>
        /// метод для ввода размеров матрицы
        /// </summary>
        /// <param name="text"></param>
        /// <returns> размеры матрицы</returns>
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
        /// <summary>
        /// создает массив массивов
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns>возвращает массив массивов</returns>
        static int[][] GenerateArrayOfArray(int n, int m)
        {
            Random rnd = new Random();
            int[][] matr = new int[n][];
            for (uint i = 0; i < n; ++i)
            {
                matr[i] = new int[n];
                for (uint j = 0; j < m; ++j)
                {
                    matr[i][j] = rnd.Next(11);
                }
            }
            return matr;
        }
        /// <summary>
        /// метод считающий сумму нечетных элементов i-го элемента массива массивов
        /// </summary>
        /// <param name="a"></param>
        /// <returns>
        /// сумму элементов</returns>
        static int GetSum(int[] a)
        {
            int sum = 0;
            for (uint j = 0; j < a.Length; ++j)
            {
                sum += a[j] % 2 == 0 ? a[j] : 0;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.Clear();
                int n = READ("размер массива n");
                int m = READ("размер массива m");
                int[][] matr = GenerateArrayOfArray(n, m);
                int[] arr = new int[m];
                for (int i = 0; i < arr.Length; ++i)
                {
                    arr[i] = GetSum(matr[i]);
                }
                Console.WriteLine("massive^2:");
                for (uint i=0;i<matr.Length;++i)
                {
                    for(uint j=0;j<matr[i].Length;++j)
                    {
                        Console.Write("{0} ", matr[i][j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("massive:");
                foreach (int i in arr)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
                Console.WriteLine("to exit escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

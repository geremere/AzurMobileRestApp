using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль2_семинар_1
{
    class Program
    {
        /// <summary>
        /// метод лялял
        /// </summary>
        /// <returns>значение переменной</returns>
        public static uint READ()
        {
            string line;
            uint n;
            do
            {
                Console.Write("введите размер квадратной матрицы:");
                line = Console.ReadLine();
                if ((!uint.TryParse(line, out n))||!(n>0)) Console.WriteLine("eror!");
            } while ((!uint.TryParse(line, out n))||!(n>0));
            return n;
        }
        /// <summary>
        /// метод
        /// </summary>
        /// <param name="n">размер мтарицы</param>
        /// <param name="matr">сама матрица</param>
        public static void MatrCreator(uint n,int[,] matr)
        {
            matr[0, 0] = 1;
            for (uint i = 0; i != n; ++i)
            {
                for (uint j=1;j!=n;++j)
                {

                    if(matr[i,j-1]==n) matr[i, j] = 1;
                        else matr[i, j] = matr[i, j - 1] + 1;
                }
                if (i != n - 1) matr[i + 1, 0] = matr[i, 0] + 1;

            }

        }
        /// <summary>
        /// вывод матрицу
        /// </summary>
        /// <param name="n"></param>
        /// <param name="matr"></param>
        public static void PrintMatr(uint n, int[,] matr)
        {
            Console.WriteLine("matrix:");
            for(uint i=0;i!=n;++i)
            {
                for (uint j=0;j!=n;++j)
                {
                    Console.Write("{0}  ",matr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n = READ();
                int[,] matr = new int[n, n];
                MatrCreator(n, matr);
                PrintMatr(n, matr);
                Console.WriteLine("to exist ESCAPE");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

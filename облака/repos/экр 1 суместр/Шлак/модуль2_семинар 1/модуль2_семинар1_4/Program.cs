using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль2_семинар1_4
{
    class Program
    {
        /// <summary>
        /// метод для ввода размеров матрицы
        /// </summary>
        /// <param name="text">принимает на ввод текст, который будет указываться в консоли</param>
        /// <returns>вывод полжительный размер матрицы</returns>
        public static int READ(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();
                if (!int.TryParse(line, out res)) Console.WriteLine("eror");
            } while (!int.TryParse(line, out res));
            return res;
        }
        /// <summary>
        /// метод, кторый заполняет и вывод матрицу
        /// </summary>
        /// <param name="n">строки</param>
        /// <param name="m">столбцы</param>
        /// <param name="matr">самам мтарица</param>
        public static void MatrCreeator(int n, int m, int[,] matr)
        {
            for (int i=0;i<n;++i)
            {
                for (int j=0;j<m;++j)
                {
                    matr[i, j] = (i + 1) * ((2 * j) + 1);
                    Console.Write("{0} ", matr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                int n = READ("введите колчество строк массива");
                int m = READ("введите количество столбцов масива");
                int[,] matr = new int[n, m];
                MatrCreeator(n, m, matr);
                Console.WriteLine("to exist escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

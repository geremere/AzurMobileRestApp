using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ProgIntro
{
    public class SquareMatrix
    {
        public int[,] matrix;
        public static Random rnd = new Random();
        /// <summary>
        /// Создаем матрицу n-порядка и заполняем ее рандомными элементами от 1 до n^2
        /// </summary>
        public void CreateMatrix(ref int[,] matrix)
        {
            int n = ReadInt("Введите количество строк в квадртатной матрице: ");
            matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, n * n);
                }
            }
        }
        /// <summary>
        /// Выводим полученную матрицу
        /// </summary>
        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(string.Format($"{matrix[i, j]}\t"));
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Считаем сумму всех определителей 2х2 матрицы
        /// </summary>
        public int CalcDeterminator(int[,] matrix)
        {
            int s = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    s += (matrix[i, j] * matrix[i + 1, j + 1] - matrix[i, j + 1] * matrix[i + 1, j]);

                }
            }
            Console.WriteLine($"Сумма равна = {s}");
            return s;
        }
        /// <summary>
        /// Убираем все нули из матрицы и сдвигаем влево, те строки в которых убрали 0
        /// </summary>
        public int[][] ZipMatrix(int[,] matrix)
        {
            int[][] matr = new int[matrix.GetLength(0)][];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matr[i] = new int[matrix.GetLength(0)];
                int k = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Array.Resize(ref matr[i], matr[i].Length - 1);
                        continue;
                    }
                    matr[i][k] = matrix[i, j];
                    k++;
                }
            }
            return matr;
        }
        /// <summary>
        /// Переворачиваем матрицу 
        /// </summary>
        public int[,] RotateMatrix(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[j, matrix.GetLength(0) - i - 1];
                    Console.Write(string.Format($"{result[i, j]}\t"));
                }
                Console.WriteLine();
            }
            return result;
        }
        /// <summary>
        /// Печатаем зубчатый массив
        /// </summary>
        public static void PrintZipMatrix(int[][] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr[i].Length; j++)
                {
                    Console.Write(string.Format($"{matr[i][j]}\t"));
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Метод для ввода целого числа
        /// </summary>
        public static int ReadInt(string message)
        {
            bool isCorrect = false;
            int result;
            do
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
                    isCorrect = true;
                else
                    Console.WriteLine("Неправильный формат числа!");
            } while (!isCorrect);

            return result;
        }
    }
    class Program
    {
        public static void Buttons(int c, SquareMatrix mix)
        {

            switch (c)
            {
                case 1:
                    mix.CreateMatrix(ref mix.matrix);
                    Console.WriteLine("Матрица создана!");
                    break;
                case 2:
                    Console.WriteLine("\n");
                    mix.PrintMatrix(mix.matrix);
                    Console.WriteLine("Печатаю матрицу");
                    break;
                case 3:
                    Console.WriteLine("\n");
                    mix.CalcDeterminator(mix.matrix);
                    break;
                case 4:
                    Console.WriteLine("\n");
                    mix.RotateMatrix(mix.matrix);
                    Console.WriteLine("Матрица повернута!");
                    break;
                case 5:
                    Console.WriteLine("\n");
                    SquareMatrix.PrintZipMatrix(mix.ZipMatrix(mix.matrix));
                    Console.WriteLine("Матрица перевернута");
                    break;
            }
        } // выбираем команду
        public static void Menu()
        {
            Console.WriteLine("Выберите операцию, которую хотите сделать:" +
                "\n\t1 - Создать новую матрицу, заполненную элементами от 0 до n*n в случайном порядке" +
                "\n\t2 - Вывести матрицу на экран" +
                "\n\t3 - Найти сумму определителей всех матриц 2х2 в этой матрице" +
                "\n\t4 - Повернуть матрицу на 90 градусов против часовой стрелки и вывести ее на экран" +
                "\n\t5 - Удалить из матрицы нулевые элементы и вывести ее на экран" +
                "\nВыберите номер команды: ");
        } // текст меню
        static void Main(string[] args)
        {
            SquareMatrix mix = new SquareMatrix();
            do
            {
                Menu();
                int c;
                Buttons(c = SquareMatrix.ReadInt(""), mix);
                Console.WriteLine("Чтобы выбрать другую команду нажмите enter");
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
    }
}

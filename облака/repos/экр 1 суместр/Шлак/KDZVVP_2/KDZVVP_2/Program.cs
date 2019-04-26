using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZVVP_2
{
    class SquareMatrix
    {
        public int[,] matrix;

        /// <summary>
        /// метод для созания матрицы N*N
        /// </summary>
        /// <returns>возхсращает созданную мтарицу</returns>
        public void CreateMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, (matrix.GetLength(0) * matrix.GetLength(1)));
                }
            }
        }

        /// <summary>
        /// Метод выводящий матрицу(если ее не инициализирование выводит матрицу нулей)
        /// </summary>
        /// <param name="n"></param>
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод вычисляющий сумму всех определителей матриц 2*2 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>        
        public int CalcDeterminators()
        {
            int sum = 0;
            for (int i = 0; i < (matrix.GetLength(0) - 1); i++)
            {
                for (int j = 0; j < (matrix.GetLength(1) - 1); j++)
                {
                    sum += matrix[i, j] * matrix[i + 1, j + 1] - matrix[i + 1, j] * matrix[i, j + 1];
                }
            }
            return sum;
        }
        /// <summary>
        /// Метод поворачивающий матрицу на 90  градусов против часовой стрелки
        /// </summary>
        /// <param name="n"> размер массива</param>
        /// <returns></returns>
        public int[,] RotateMatrix()
        {
            int[,] reverse = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    reverse[i, j] = matrix[j, matrix.GetLength(1) - i - 1];
                }
            }
            return reverse;
        }
        /// <summary>
        /// метод создающий ссылочную матрицу без нулей
        /// </summary>
        /// <returns> ссылочный массив без нулей</returns>
        public int[][] ZipMatrix()
        {
            int[][] ar = new int[matrix.GetLength(0)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) sum++;
                }

                int capacity = 0;
                ar[i] = new int[matrix.GetLength(1) - sum];
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[i, l] != 0)
                    {
                        ar[i][capacity] = matrix[i, l];
                        capacity++;
                    }
                }
            }
            return ar;
        }
    }
    class Program
    {
        /// <summary>
        /// Метод ввода
        /// </summary>
        /// <param name="texе">передаваемый текст, который выведется на экран</param>
        /// <param name="k">граница ввода</param>
        /// <returns></returns>
        public static int Read(string text, int k)
        {
            string line;
            int res;
            do
            {
                Console.Write($"{text}: ");
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res)) || (res < k)) Console.WriteLine("Ошибка ввода!?");
            } while ((!int.TryParse(line, out res)) || (res < k));
            return res;
        }
  
        /// <summary>
        /// Метод вывода меню на экран
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("\t\t Menu: \t \t\n");
            Console.WriteLine("0 - Создать новую матрицу заполненную элементами от 0 до n*n в случайном порядке \n" +
                "1 - Вывести мтарицу на экран \n" +
                "2 - найти усммму определителей всех матриц 2*2 в этой матрице \n" +
                "3 - Повернуть эту матрицу на 90и градусов  против часовой стрелки и вывести ее на экран\n" +
                "4 - Удалить из мтарицы все нулевые эелменты и вывести ее на экран\n");
        }
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.Clear();
                SquareMatrix sm = new SquareMatrix();
                PrintMenu();
                ConsoleKeyInfo key;
                do
                {
                    int sumdet;
                    int swcase = Read("Введите номер команды", 0);
                    switch (swcase)
                    {
                        // create a matix
                        case 0:
                            try
                            {
                                int n = Read("введите размеры матрицы", 2);
                                sm.matrix = new int[n, n];
                                sm.CreateMatrix();
                            }
                            catch(OutOfMemoryException e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            //я знаю что так лучше не делать но в здании нужно было использовать эксепшены так что я решил показать что так вприцепи можно сделать
                            break;
                        //print matrix
                        case 1:
                            if (sm.matrix != null)
                            {
                                sm.PrintMatrix();
                            }
                            else
                            {
                                Console.WriteLine("матрица еще не создана");                               
                            }
                            break;


                        //determenant
                        case 2:
                            if (sm.matrix != null)
                            {
                                sumdet = sm.CalcDeterminators();
                                Console.WriteLine(sumdet);
                            }
                            else
                            {
                                Console.WriteLine("матрица еще не создана");
                            }
                            break;
                        
                            //Rotate matrix and print them
                        case 3:
                            if (sm.matrix != null)
                            {
                                sm.matrix = sm.RotateMatrix();
                                sm.PrintMatrix();
                            }
                            else
                            {
                                Console.WriteLine("матрица еще не создана");
                            }
                            break;                           
                        
                            //create matrix wihtout zeroes
                        case 4:
                            if (sm.matrix != null)
                            {
                                 int[][] mat =sm.ZipMatrix();
                                foreach (int[] i in mat)
                                {
                                    foreach (int j in i)
                                    {
                                        Console.Write($"{j}\t");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("матрица еще не создана");
                            }
                            break;

                        default:
                            Console.WriteLine("ошибка ввода повторите выбор команды");
                            break;
                    }

                    Console.WriteLine("Чтобы повторить действие в меню нажмите enter");
                    key = Console.ReadKey(true);
                } while (key.Key==ConsoleKey.Enter);

                Console.WriteLine("to exit escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

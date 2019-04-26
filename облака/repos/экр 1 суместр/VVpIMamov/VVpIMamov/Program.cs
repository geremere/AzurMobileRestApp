using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plane;

namespace VVpIMamov
{
    /* Имамов Радмир Маратович
     * Бпи 183-2
     * 19.12.18
     * Вариант-1
     */
    class Program
    {
        /// <summary>
        /// чтение элемента меню
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int Read(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write($"{text}: ");
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res) || (res < 1) || (res > 6))) Console.Write(" Eror\n");
            } while (!int.TryParse(line, out res) || (res < 1) || (res > 6));
            return res;
        }

        /// <summary>
        /// чтение длины массива
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int Read1(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write($"{text}: ");
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res))) Console.WriteLine(" Eror\n");
            } while (!int.TryParse(line, out res));
            return res;
        }
        /// <summary>
        /// меню
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("1 - Create massive of Rectangular\n" +
                "2 -  Show information about Rectngulars\n" +
                "3 - Create massive of Square\n" +
                "4 - Show information abour Squres\n" +
                "5 - Massive Rectangulars + Masivve Squares ang show information about their\n" +
                "6 - Clear Console");
        }

        /// <summary>
        /// заполнение массива А
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public static Rectancular[] MassiveAcreater(int a1)
        {
            Rectancular[] A = new Rectancular[a1];
            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                double x1 = rnd.Next(-49, 49) + rnd.NextDouble();
                double x2 = rnd.Next(-49, 49) + rnd.NextDouble();
                double y1 = rnd.Next(-49, 49) + rnd.NextDouble();
                double y2 = rnd.Next(-49, 49) + rnd.NextDouble();

                try
                {
                    A[i] = new Rectancular(x1 > x2 ? x1 : x2, y1 > y2 ? y2 : y1, x1 > x2 ? x2 : x1, y1 > y2 ? y1 : y2);
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                catch (OutOfMemoryException e2)
                {
                    Console.WriteLine(e2.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return A;
            
        }

        /// <summary>
        /// Вывод информации о массиве А
        /// </summary>
        /// <param name="A"></param>
        public static void ShowAInfoA(Rectancular[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i].ToString());
            }
        }

        /// <summary>
        /// Вывод информации о массиве В
        /// </summary>
        /// <param name="A"></param>
        public static void ShowAInfoB(Square[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]!=null)
                    Console.WriteLine(A[i].ToString());
            }
        }

        /// <summary>
        /// Заполнение массива В
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public static Square[] MassiveBcreater(int b1, int score)
        {
            Square[] B = new Square[b1];

            Random rnd = new Random();
            for (int i = 0; i < B.Length; i++)
            {
                double x1 = rnd.Next(-49, 49) + rnd.NextDouble();
                double x2 = rnd.Next(-49, 49) + rnd.NextDouble();                

                try
                {
                        B[i] = new Square(x1 > x2 ? x1 : x2, x1 > x2 ? x2 : x1, x1 > x2 ? x2 : x1, x1 > x2 ? x1 : x2);
                }
                catch(IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                catch (OutOfMemoryException e2)
                {
                    Console.WriteLine(e2.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return B;

        }

        /// <summary>
        /// Слияние А и В
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void APLusB(Rectancular[] A, Square[] B)
        {
            Rectancular[] C = new Rectancular[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }

            for (int i = A.Length; i < C.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    C[i] = B[j];
                }
            }

            C = C.OrderBy(s => s.S).ToArray();
            Print(C);
        }

        /// <summary>
        /// вывод А+В
        /// </summary>
        /// <param name="C"></param>
        public static void Print(Rectancular[] C)
        {
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine(C[i].ToString());
            }
        }


        static void Main(string[] args)
        {
            ConsoleKeyInfo k;//внешний цикл
            do
            {
                ConsoleKeyInfo z;
                Square[] B = null;
                Rectancular[] A= null;

                do//внутренний цикл
                {
                    Menu();
                    int choise;
                    choise = Read("введите число того дейсвие, которые вы хотите выпролнить");

                    int a1, b1, score=0;
                    

                    switch (choise)
                    {
                        case 1:
                            a1 = Read1("введите количестов элементов массива прямоугольников");
                            try
                            {
                                A = MassiveAcreater(a1);
                            }
                            catch (IndexOutOfRangeException e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            catch (OutOfMemoryException e2)
                            {
                                Console.WriteLine(e2.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        
                        case 2:
                            try
                            {
                                if (A == null) throw new NullReferenceException();
                                    ShowAInfoA(A);
                            }
                            catch (IndexOutOfRangeException e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            catch (OutOfMemoryException e2)
                            {
                                Console.WriteLine(e2.Message);
                            }
                            catch(NullReferenceException e3)
                            {
                                Console.WriteLine(e3.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 3:
                            b1 = Read1("введите количестов элементов массива квадратов");
                            try
                            {
                                B = MassiveBcreater(b1, score);
                            }
                            catch (IndexOutOfRangeException e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            catch (OutOfMemoryException e2)
                            {
                                Console.WriteLine(e2.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 4:
                            try
                            {
                                if (B == null) throw new NullReferenceException();
                                ShowAInfoB(B);
                            }
                            catch (IndexOutOfRangeException e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            catch (OutOfMemoryException e2)
                            {
                                Console.WriteLine(e2.Message);
                            }
                            catch (NullReferenceException e3)
                            {
                                Console.WriteLine(e3.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        case 5:
                            try
                            {
                                if (B == null || A == null) throw new NullReferenceException();
                                APLusB(A, B);
                            }
                            catch (IndexOutOfRangeException e1)
                            {
                                Console.WriteLine(e1.Message);
                            }
                            catch (OutOfMemoryException e2)
                            {
                                Console.WriteLine(e2.Message);
                            }
                            catch (NullReferenceException e3)
                            {
                                Console.WriteLine(e3.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 6:
                            Console.Clear();
                            Menu();
                            break;
                    }

                    Console.WriteLine("to continue enter");
                    z = Console.ReadKey(true);
                } while (z.Key == ConsoleKey.Enter);

                Console.WriteLine("to exit escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

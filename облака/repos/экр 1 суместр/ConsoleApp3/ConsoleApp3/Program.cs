using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianguleLibrary;

namespace ConsoleApp3
{
    class Program
    {

        public static int Read(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write($"{text}: ");
                line = Console.ReadLine();
            } while (!int.TryParse(line, out res));
            return res;
        }

        public static Triangle[] ArrayCreator(int n, Random rnd)
        {
            Triangle[] arr;
            try
            {
                arr = new Triangle[n];
                if (n <= 0 || n >= 1000) throw new ArgumentException();
            }
            catch (ArgumentException e1)
            {
                Console.WriteLine(e1.Message);
                return null;
            }
            catch (StackOverflowException e2)
            {
                Console.WriteLine(e2.Message);
                return null;
            }
            catch (Exception e3)
            {
                Console.WriteLine(e3.Message);
                return null;
            }
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (rnd.Next(1, 101) <= 35)
                    {
                        arr[i] = new RightTrianglar(rnd.Next(0, 30) + rnd.NextDouble(), rnd.Next(0, 30) + rnd.NextDouble());
                    }
                    else
                    {
                        arr[i] = new EqualitionTriangle(rnd.Next(0, 30) + rnd.NextDouble());
                    }
                    Console.WriteLine(arr[i].GetType()+"\n"+arr[i].ToString());
                }
            }
            catch (NullReferenceException e2)
            {
                Console.WriteLine(e2.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return arr;

        }

        public static void Heght(Triangle[] arr, Random rnd)
        {
            RightTrianglar t1 = new RightTrianglar(rnd.Next(0, 30) + rnd.NextDouble(), rnd.Next(0, 30) + rnd.NextDouble());
            Console.WriteLine(t1.ToString());
            Console.WriteLine($"Элементы массива, которые являются прямоугодьными и их высота больше , чем {t1.MaxHeight():f3}");
            for (int i = 0; i < arr.Length; i++)
            {
                if((arr[i] is RightTrianglar)&&(arr[i].MaxHeight()>t1.MaxHeight()))
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }


        }

        public static void EqualiationTryangle(Triangle[] arr, Random rnd)
        {
            EqualitionTriangle t2 = new EqualitionTriangle(rnd.Next(0, 30) + rnd.NextDouble());
            Console.WriteLine(t2.ToString());
            Console.WriteLine($"информация о правильных треглоьников у окторых площадь больше чем {t2.Square():f3}");
            for (int i = 0; i < arr.Length; i++)
            {
                if((arr[i] is EqualitionTriangle) &&(arr[i].Square()>t2.Square()))
                {
                    Console.WriteLine(arr[i].ToString());
                }

            }
            Console.WriteLine($"<{t2.Square():f3} умножаем на 2");
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] is EqualitionTriangle) && (arr[i].Square() < t2.Square()))
                {
                    EqualitionTriangle a = new EqualitionTriangle(arr[i].A);
                    a.Resize(2);
                    arr[i] = a;
                    Console.WriteLine(arr[i].ToString());
                }
            }

        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                int n = Read("введите n");
                Random rnd = new Random();
                Triangle[] arr = ArrayCreator(n, rnd);
                Console.WriteLine("=======================");
                Heght(arr, rnd);
                Console.WriteLine("=======================");
                EqualiationTryangle(arr, rnd);
                Console.WriteLine("to exit Escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

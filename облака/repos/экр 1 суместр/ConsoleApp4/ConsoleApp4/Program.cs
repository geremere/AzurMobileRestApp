using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericLabrary;

namespace ConsoleApp4
{
    class Program
    {
        /// <summary>
        /// метод ввода длины массива пар
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
                if (!int.TryParse(line, out res) || res <= 0) Console.WriteLine("Eror");
            } while (!int.TryParse(line, out res)||res<=0);
            return res;
        }
            
        /// <summary>
        /// инициалиирование массива пар
        /// </summary>
        /// <param name="n"></param>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static Pair[] PairCreator(int n, Random rnd)
        {
            Pair[] arr = new Pair[n];
            for (int i = 0; i < arr.Length; i++)
            {
                if(rnd.Next(1,101)<=45)
                {
                    arr[i] = new Complex(rnd.Next(-50, 51),rnd.Next(-50,51));
                }
                else
                {
                    try
                    {
                        arr[i] = new Rational(rnd.Next(-50, 51), rnd.Next(-50, 51));
                    }
                    catch(ArgumentNullException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                }
            }
            return arr;
        }

        /// <summary>
        /// вывод массива пар
        /// </summary>
        /// <param name="arr"></param>
        public static void Print(Pair[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i].ToString());
                }
                catch(NullReferenceException)
                {
                    continue;
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// опреции с дробями
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rnd"></param>
        public static void RandomRational(Pair[] arr, Random rnd)
        {
            Rational r=null;
            do
            {
                try
                {
                    r = new Rational(rnd.Next(-50, 51), rnd.Next(-50, 51));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (r == null);
            Console.WriteLine($"new Rational Value= {r.ToString()}");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Rational)
                {
                    if (arr[i].Equal(r) == 1)
                    {
                        Console.WriteLine(arr[i].ToString() + "*" + r.ToString() + "=" + arr[i].Mult(r));
                    }
                }
            }
        }

        /// <summary>
        /// опреации с комплексными числами
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="rnd"></param>
        public static void RandomComplex(Pair[] arr, Random rnd)
        {
            Complex c = new Complex(rnd.Next(-50, 51), rnd.Next(-50, 51));
            Console.WriteLine("new Complex Value"+c.ToString());
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] is Complex)
                {
                    Console.WriteLine(arr[i].ToString());
                    Complex cx1 = (Complex)arr[i];
                    Console.WriteLine(arr[i].ToString() + "+" + c.ToString() + "=" + cx1.Add(c).ToString());
                    Complex cx2 = (Complex)arr[i];
                    Console.WriteLine(arr[i].ToString() + "-" + c.ToString() + "=" + cx2.Sub(c).ToString());
                    Complex cx3 = (Complex)arr[i];
                    Console.WriteLine(arr[i].ToString() + "*" + c.ToString() + "=" + cx3.Mult(c).ToString());



                }
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                int n = Read("введите n");
                Random rnd = new Random();
                Console.WriteLine("massive of Pair:");
                Pair[] arr = PairCreator(n, rnd);
                Print(arr);
                Console.WriteLine("massive of Rational");
                RandomRational(arr, rnd);
                Console.WriteLine("massive of Complex");
                RandomComplex(arr, rnd);
                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }
    }
}

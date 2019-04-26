using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMRMOdul2_ImamovRadmir183
{
    /// <summary>
    /// Имамов Радмир Маратович
    /// Бпи 183-2
    /// 20.11.18
    /// Варинат: 1
    /// </summary>
    class Program
    {
        /// <summary>
        /// метод ввода числа
        /// </summary>
        /// <param name="text"></param>
        /// <returns>возвращает обработанное число</returns>
        public static int Read(string text)
        {
            string line;
            int res;
            do
            {
                Console.Write($"{text}: ");
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res))||(res<1)) Console.WriteLine("Eror");
            } while ((!int.TryParse(line, out res))||(res<1));
            return res;
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.Clear();
                Random rnd = new Random();
                double q11 = rnd.Next(-10, 10) + rnd.NextDouble();
                double q12 = rnd.Next(-10, 10) + rnd.NextDouble();
                double q21 = rnd.Next(-10, 10) + rnd.NextDouble();
                double q22 = rnd.Next(-10, 10) + rnd.NextDouble();

                Point2d p = new Point2d(3, 4);
                Point2d p1 = p[2];
                Point2d a = new Point2d(q11, q12);
                Point2d b = new Point2d(q21, q22);
                Console.WriteLine($"{p.Dictance(a):f2}");
                p.Closer(a, b);
                Console.WriteLine($"{p.Closer(a, b).X:f2}  {p.Closer(a, b).Y:f2}");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

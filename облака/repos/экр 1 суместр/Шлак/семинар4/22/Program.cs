using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace _22
{
    class Program
    {
        public static Point[][] FigArray(Random rnd)
        {
            Point[][] arr = new Point[2][];
            arr[0] = new Point[rnd.Next(0, 11)];
            for (int i = 0; i < arr[0].Length; i++)
                arr[0][i] = new Circle(rnd.Next(10, 101), rnd.Next(10, 101), rnd.Next(10, 101));
            arr[1] = new Point[rnd.Next(0, 11)];
            for (int i = 0; i < arr[1].Length; i++)
                arr[1][i] = new Square(rnd.Next(10, 101), rnd.Next(10, 101), rnd.Next(10, 101));
            return arr;
        }
        public static void Print(Point[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j].ConsoleDisplay();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Point[][] array = FigArray(rnd);
            Console.WriteLine("insort massive:\n");
            Print(array);
            Console.Read();
        }
    }
}

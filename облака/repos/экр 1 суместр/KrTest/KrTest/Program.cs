using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrTest
{
    
    class Program
    {
        public static int Read()
        {
            string line;
            int res;
            do
            {
                Console.Write("Введите n: ");
                line = Console.ReadLine();
            } while (!int.TryParse(line, out res));
            return res;
        }


        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
            int n = 0;

            n = Read();
            Random rnd = new Random();
            Pair[][] arr = new Pair[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Complex[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = new Complex(rnd.Next(-10, 11), rnd.Next(-10, 11));
                    Complex z = new Complex(rnd.Next(-10, 11), rnd.Next(-10, 11));
                    Console.Write($"{arr[i][j].ToString()} * {z.ToString()} = ");
                    Console.WriteLine(arr[i][j].Mult(z).ToString());
                    Console.Write($"{arr[i][j].ToString()} + {z.ToString()} = ");
                    Console.WriteLine(arr[i][j].Add(z).ToString());
                }
            }
            k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);

        }
    }

}

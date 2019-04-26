using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        public static uint READ()
        {
            string line;
            uint res;
            do
            {
                Console.Write("matrix score: ");
                line = Console.ReadLine();
            } while ((!uint.TryParse(line, out res)) || (res <= 0));
            return res;
        }
        public static int[,] CreatorMatrix(uint n, uint m)
        {
            int[,] matr = new int[n, m];
            Random rnd = new Random();
            for (uint i=0;i<n;++i)
            {
                for (uint j=0;j<m;++j)
                {
                    matr[i, j] = rnd.Next(100);
                    Console.Write("{0,4}", matr[i, j]);
                }
                Console.WriteLine();
            }
            return  matr;
        }
        public static void MatrixTransform(int [,] matr, uint z, uint m)
        {
            int sum = 0, proz = 1; 
            for (uint i=0;i<m;++i)
            {
                sum += matr[z, i];
                proz *= matr[z, i];
            }
            Console.Write("сумма строки: {0,4}\n" +" произведние строки:{1,4}\n", sum, proz);
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint n = READ();
                uint m = READ();
                uint z = READ();
                int[,] matr = CreatorMatrix(n, m);
                MatrixTransform(matr, z, m);
                Console.WriteLine("to exist escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        public static int Read()
        {
            string line;
            int res;
            do
            {
                Console.Write("введите длину массива: ");
                line = Console.ReadLine();
            } while ((!int.TryParse(line, out res)) || (res < 1));
            return res;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                int size = Read();
                Random rnd = new Random();
                ItemList IL = new ItemList(size, ref rnd);
                IL.AddElement(rnd.Next(1,101));
                IL.RemoveFirst(5);
                Console.WriteLine("\nto exist escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

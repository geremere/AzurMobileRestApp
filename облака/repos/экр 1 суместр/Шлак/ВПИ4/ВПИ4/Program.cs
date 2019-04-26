using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВПИ4
{
    class Program
    { public static uint reading(string text)
        {
            string line;
            uint res;
            do
            {
                Console.WriteLine("{0}", text);
                line = Console.ReadLine();

                if ((!uint.TryParse(line, out res)) || (res == 0))
                    Console.WriteLine("ошибка ввода");

            } while ((!uint.TryParse(line, out res)) || (res == 0));
            return res;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                uint n = reading("введите целую длину массива");
                int[] array = new int[n];
                array[0] = 2;
                Console.Write(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = array[i - 1] * 2;
                    Console.Write(" ");
                    Console.Write(array[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("для выхода из пограммы нажмите escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

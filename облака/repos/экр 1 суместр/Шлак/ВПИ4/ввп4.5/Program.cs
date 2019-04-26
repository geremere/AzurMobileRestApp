using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ввп4._5
{
    class Program
    {
        public static void ArrayCreater( ref int[] array )//инициализация массива
        {
            Random rnd = new Random();
            for(int i=0;i<array.Length;i++)
            {
                array[i] = rnd.Next(100);
                Console.Write("{0} ", array[i]);
            }

        }
        public static void MinArray(int[] array)
        {
            int min,value;
            min = array[0];
            for (int i=1; i<array.Length; i++)
            {
                min = (array[i]<min?array[i]:min);
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (min == array[i])
                {
                    if (array[i]%2==0) Console.Write("четный индекс минимального числа в массиве:{0}", i);
                }
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Random rnd = new Random();
                int[] array = new int[rnd.Next(1, 10)];
                ArrayCreater(ref array);
                Console.WriteLine("для выхода escape");
                k = Console.ReadKey(true);
            } while (k.Key!=ConsoleKey.Escape);
        }
    }
}

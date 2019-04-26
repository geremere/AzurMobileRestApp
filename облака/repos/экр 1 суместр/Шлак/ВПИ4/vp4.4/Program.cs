using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp4._4
{
    class Program
    {
        public static uint Reading(string text)//метод чтения перменных
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();

                if ((!uint.TryParse(line, out res))||(res==0))
                    Console.WriteLine("ошибка ввода");

            } while ((!uint.TryParse(line, out res))||(res==0));
            return res;
        }
        public static void swap(ref uint n, ref uint k)//метод свапа переменных k and n
        {
            if (k>n)
            {
                k = k + n;
                n = k - n;
                k = k - n;
            }
        }
        public static void ArrayCreater(ref uint[] A,uint k)//метод заполнения переменных
        {
            Random rnd = new Random();
            for (int i=0; i<A.Length;i++)
            {
                uint value =(uint) rnd.Next(10);
                A[i] = value;
                if ((A[i] % k) == 0) Console.Write($"{i}:{A[i]}; ");
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo z;
            do
            {
                Console.Clear();
                uint n = Reading("N>0");
                uint k = Reading("K>0");
                swap(ref n, ref k);
                uint[] A = new uint[n];
                ArrayCreater(ref A, k);
                Console.WriteLine("\n");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"{i}:{A[i]} ");
                }
                Console.WriteLine("");
                Console.WriteLine("escape");
                z = Console.ReadKey(true);
            } while (z.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    { 
        public static uint Read(string text)
        {
            string line;
            uint res;
            do
            {
                Console.WriteLine("{0}",text);
                line = Console.ReadLine();
                if (!uint.TryParse(line, out res)) Console.WriteLine("eror");
            } while (!uint.TryParse(line, out res));
            return res;
        }
        public static void ArrayCreater(char[] arr, ref Random rnd)
        {
            Console.Write("massive: ");
            for (int i=0; i!=arr.Length; ++i)
            {
                arr[i] = (char)(rnd.Next(65, 91));
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        public static void NewArray(char[] arr,int[] resar)
        {
            for (int i=0; i<arr.Length;i++)
            {
                resar[i] = (int)arr[i];
            }
        }
        public static void Result(char[] arr, int[] resar)
        {
            Console.Write("resul array:");
            for (int i=0; i<arr.Length;i++)
            {
                arr[i] = (char)resar[i];
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Random rnd = new Random();
                uint n = Read("введите челую полительную длинну массива n");
                char[] arr = new char[n];
                ArrayCreater(arr, ref rnd);
                int[] resar = new int[n];
                NewArray(arr, resar);
                Array.Sort(resar);
                Result(arr, resar);
                Console.WriteLine("to exit escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

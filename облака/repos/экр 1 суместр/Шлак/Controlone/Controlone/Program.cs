using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlone
{
    class Program
    {
        /*
         * Имамов Радмир Маратович
         * группа: БПИ183
         * Вариант: 16
         * дата:16.10.2018
         */
        public static uint Readn(string text)//метод ввода числа N
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();
                if ((!uint.TryParse(line, out res))||(res<1)) Console.WriteLine("ошибка ввода!");
            } while ((!uint.TryParse(line, out res))||(res<1));
            return res;
        }
        public static int Readab(string text)//метод ввода числа Aи B
        {
            string line;
            int res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();
                if (!int.TryParse(line, out res)) Console.WriteLine("ошибка ввода!");
            } while (!int.TryParse(line, out res));
            return res;
        }
        public static void Swap (ref int a, ref int b)//метод свапа a и b
        {
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
        }
        public static void Dispers(int[] ar)//метод вычисляет и выводит мат ожидания и дисперсии
        {
            int m=0, d=0;
            for(int i=0;i<ar.Length;++i)
            {
                m +=ar[i] * ar[i];
                d += (ar[i] - m)*(ar[i] - m);
            }
            double M = (double)m / ar.Length;
            double D = (double)d / ar.Length;
            Console.WriteLine("D = {0} ", D);
            Console.WriteLine("m = {0} ", M);
        }
        public static int[] Array(int a,int b,uint n,ref int min, ref int max,Random rnd)//метод создающий и возращающий массив также вычисляет минимальное и максмальное значение массива
        {
            int[] array = new int[n];
            Console.Write("Array:");
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    array[i] = array[i] + rnd.Next(a, b + 1);
                }
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            min = array.Min();
            max = array.Max();
            return array;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;//цикл решения программы
            do
            {
                int max = 0, min = 0;//инициализация переменных для реф
                Random rnd = new Random();
                uint n = Readn("введите длину массива n");
                int a = Readab("введите границу а");
                int b = Readab("введите границу b");
                Console.WriteLine("если a>b елеменьы поменяются местами");
                Swap(ref a, ref b);
                int[] ar = Array(a, b, n, ref min, ref max,rnd);
                Console.Write("min = {0} ", min);
                Console.Write("max = {0} ", max);
                Console.WriteLine();
                Dispers(ar);
                Console.WriteLine("to exist Escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

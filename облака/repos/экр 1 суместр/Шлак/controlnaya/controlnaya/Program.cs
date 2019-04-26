using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Группа: бпи183 
 * Имамов Радмир Мратович 
 * Задача:
 * Вариант:4
 * nchuykin@hse.ru
 */

namespace ex3
{
    class Program
    {
        public static uint A(string number)//метод для ввода числа a and delta
        {
            string reading;
            uint result;
            do
            {
                Console.WriteLine("Введите {0}:", number);
                reading = Console.ReadLine();
                if (!uint.TryParse(reading, out result)) Console.WriteLine("ошибка ввода");
            }
            while (!uint.TryParse(reading, out result));
            return result;
        } 
        private static bool Transform(ref uint numb)
        {
            if (numb < 100 || numb > 999)
                return false;
            uint q1 = numb % 10;
            uint q2 = ((numb % 100) - q1)/10;
            uint q3 = (numb - (numb % 100)) / 100;
            uint max = Math.Max(q1, Math.Max(q2, q3));
            uint min = Math.Min(q1, Math.Min(q2, q3));
            uint middle = q1 + q2 + q3 - max - min;
            numb = min*100+middle*10+max;
            return true;
        }
        static void Main()
        {
            ConsoleKeyInfo K;
            do
            {
                uint numb = A("3-ое число");
                bool tr = Transform(ref numb);
                Console.WriteLine(numb);
                Console.WriteLine("для выхода из программы нажмите ESCAPE");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);//цикл повторения решения
        }
    }
}

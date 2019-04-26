using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Дисциплина: "Программирование"
Группа: БПИ183-2
Студент: Имамов Радмир Маратович
Дата: 25.09.2018
Задача: 
*/


namespace exersize2
{
    class Program
    {
        public static int A(string number)
        {
            string reading;
            int result;
            do
            {
                Console.WriteLine("Введите {0}:", number);
                reading = Console.ReadLine();
                if (!int.TryParse(reading, out result)) Console.WriteLine("ошибка ввода");
            }
            while (!int.TryParse(reading, out result));
            return result;
        }
        public static bool Function(bool p, bool q)
        {
            bool res = !(p & q) & !(p | q);
            return res;
        }
            
            static void Main()
        {
            ConsoleKeyInfo K;
            do
            {
                bool p = true, q, res;
                Console.WriteLine("Таблица истиности !(p&q)&!(p|q)");
                Console.WriteLine("p \t q \t F");
                do
                {
                    q = true;
                    do
                    {
                        res = Function(p, q);
                        Console.WriteLine("{0}\t{1}\t{2}", p, q, res);
                        q = !q;
                    } while (!q);
                    p = !p;

                } while (!p);

                Console.WriteLine();
                Console.WriteLine("Для выхода из программы нажмите ESCAPE");
                K = Console.ReadKey(true);
            }
            while (K.Key != ConsoleKey.Escape);
        }
    }
}

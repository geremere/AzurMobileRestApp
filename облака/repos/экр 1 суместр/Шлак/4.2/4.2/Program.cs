using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        public static char reading()
        { string line;
            char text;
            do
            {
                Console.WriteLine("введите символ строчной латинской буквы:");
                line = Console.ReadLine();
                if (!char.TryParse(line, out text))
                    {
                    Console.WriteLine("ошибка ввода");
                    }
            } while (!char.TryParse(line, out text));
            return text;
        }
        public static bool Shift(ref char read)
        {
            bool result;
            if (((int)read<97)||((int)read>122))
            {
                return false;
            }
            else
            {
                if (((int)read > 118))
                {
                    read = ((char)((int)read-22));
                }
                else
                {
                    read = ((char)((int)read + 4));
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                char read = reading();
                bool logic = Shift(ref read);
                Console.WriteLine(logic);
                if (logic)Console.WriteLine(read);
                Console.WriteLine("Для выхода из программы нажмите Escape");
                K = Console.ReadKey(true);
            } while (K.Key!=ConsoleKey.Escape);
        }
    }
}

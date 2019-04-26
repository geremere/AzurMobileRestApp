using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__
{
    class Program
    {
        public static int reading(string text)
        {
            string line;
            int res;
            do
            {
                Console.WriteLine(text);
                line = Console.ReadLine();
                if (!int.TryParse(line, out res)) 
            } while (!int.TryParse(line, out res));
            return res;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo K;
            do
            {
                int a = reading("");
                int b = reading("b");              
                Console.WriteLine("для выхода из программы нажмите escape");
                K = Console.ReadKey(true);
            } while (K.Key != ConsoleKey.Escape);
        }
    }
}

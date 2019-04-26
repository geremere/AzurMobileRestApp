using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ConsoleKeyInfo k;
            do
            {
                string line;
                line = READ(rnd);
                Console.WriteLine(line);
                MoveOff(ref line);
                Console.WriteLine(line);
                
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }

        private static void MoveOff(ref string line)
        {
            string newline = Console.ReadLine();           
            for (int i = 0; i < newline.Length; i++)
            {
                line = line.Replace($"{newline[i]}", "");
            }

        }

        private static string READ(Random rnd)
        {
            string line="";
            int count=0;
            try
            {
                count = int.Parse(Console.ReadLine());
                if (count <= 0) throw new ArgumentException("count>0");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                line = READ(rnd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                line = READ(rnd);
            }
            for (int i = 0; i < count; i++)
            {
                line += (char)rnd.Next(65, 90);
            }
            return line;
        }
    }
}

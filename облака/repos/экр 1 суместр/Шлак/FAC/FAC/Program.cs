using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAC
{
    class Program
    {
        public static int reading(string text)
        {
            string line;
            int result;
            do
            {
                Console.WriteLine("введите число{0}", text);
                line = Console.ReadLine();
                if (!int.TryParse(line, out result)) Console.WriteLine("ошибка ввода");
            } while (!int.TryParse(line, out result));
            return result;
        }
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < 4; i++)
            {
              array [i] = reading("напишите число");
            }
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                for (int j= 0; j < 4; j++)
                {
                    if (array[i]==array[j]) k++;
                }
                if (k < 2) Console.WriteLine(i);
            }
        }
    }
}

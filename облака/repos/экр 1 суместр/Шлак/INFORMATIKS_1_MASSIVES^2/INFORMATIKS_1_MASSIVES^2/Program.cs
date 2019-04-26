using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFORMATIKS_1_MASSIVES_2
{
    class Program
    {
        public static uint READ(string text)
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}: ",text);
                line = Console.ReadLine();
            } while (!uint.TryParse(line, out res));
            return res;

        }
        static void Main(string[] args)
        {
            uint n = READ("введите размерность массива N");
            
        }
    }
}

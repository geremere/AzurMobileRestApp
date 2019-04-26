using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testvbreak
{
    class Program
    {
        public static uint Reading(string text)
        {
            string line;
            uint res;
            do
            {
                Console.Write("{0}: ", text);
                line = Console.ReadLine();

                if (!uint.TryParse(line, out res))
                    Console.WriteLine("ошибка ввода");

            } while (!uint.TryParse(line, out res));
            return res;
        }
        static void Main(string[] args)
        {
            bool chek;
            do
            {
                chek = true;
                int k = 0;
                Console.Write(k);
                uint a = Reading("1");
                uint b = Reading("2");
                for(int i=0;i<10;i++)
                {
                    for (int j=0;j<10;j++)
                    {
                        a = a + b;
                        uint po = uint.MaxValue;
                        if (a> uint.MaxValue)
                        {
                            chek = false;
                            break;
                        }
                    }
                   if (!chek) break;
                    Console.WriteLine(i);
                }
            } while (chek);
            Console.WriteLine(true);
        }
    }
}

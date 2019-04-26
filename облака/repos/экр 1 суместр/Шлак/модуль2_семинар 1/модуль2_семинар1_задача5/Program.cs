using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль2_семинар1_задача5
{
    class Program
    {
        public static uint READ()
        {
            string line;
            uint res;
            do
            {
                Console.Write("vvedi n: ");
                line = Console.ReadLine();
            } while ((!uint.TryParse(line, out res)) || (res<=0));
            return res;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                int[][] pascal;
                uint n = READ();
                pascal = new int[n+1][];
                for (uint i=0;i<pascal.Length;++i)
                {
                    pascal[i]=new int [i+1];
                    pascal[i][0] = pascal[i][i] = 1;
                    for (uint j=1;j<i;++j)
                    {
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                    }
                }
                foreach (int[] ar in pascal)
                {
                    foreach (int cnk in ar)
                    {
                        Console.Write("{0,5}", cnk);
                    }
                    Console.WriteLine();
                }
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

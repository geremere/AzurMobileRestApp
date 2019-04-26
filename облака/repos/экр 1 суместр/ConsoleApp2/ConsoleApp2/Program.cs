using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char s, beg = 'S', end = (char)(beg + 5);
            for (s = beg; s < end; s++)
                if (s % beg == 0) Console.Write(s);
                else continue;
            Console.Read();
        }
    }
}

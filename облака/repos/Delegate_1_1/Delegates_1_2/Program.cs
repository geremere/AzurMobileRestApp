using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegater del = new Delegater();
            int[] ar = del.arr(int.Parse(Console.ReadLine()));
            del.newmet(ar);
            foreach (int e in ar)
            {
                Console.Write($"{e}  ");
            }
            Console.Read();
        }
    }
}

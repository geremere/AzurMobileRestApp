using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1_1
{
    delegate int Cast(double d);
    delegate string MEs(double d);
    class Program
    {
        static void Main(string[] args)
        {
            Cast first = d =>
            {
                if(d - (int)d >= 0.5)
                {
                    if (((int)d + 1) % 2 == 0) return (int)d + 1;
                    else return (int)d;
                }
                else
                {
                    if ((int)d % 2 == 0) return (int)d;
                    else return (int)d + 1;
                }
            };
            Cast second = d =>
            {
                string k = $"{d}";
                return k.Length;
            };
            //first += second;
            //MEs sum = d => { return $"{first(d)}\n{second(d)}"; };
            //Console.WriteLine(sum(double.Parse(Console.ReadLine())));
            //Console.WriteLine(first(double.Parse(Console.ReadLine())));
            //Console.WriteLine(second(double.Parse(Console.ReadLine())));
            //Console.WriteLine(second(double.Parse(Console.ReadLine())));

            Console.Read();


        }
    }
}

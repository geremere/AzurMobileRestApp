using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ср
{
    public delegate bool Eq(Circle e);

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Random rnd = new Random();
                Circle[] cr = new Circle[15];
                for (int i = 0; i < 15; i++)
                {
                    cr[i] = new Circle(rnd.Next(-11, 9) + rnd.NextDouble(), rnd.Next(0, 7) + rnd.NextDouble());
                    Console.WriteLine(cr[i].ToString());
                }
                double s;
                IRead(out s);
                int crore = 0;
                Eq eq = e =>
                {
                    if (e.R * e.R * Math.PI > s)
                    {
                        return true;
                    }
                    return false;
                };
                Console.WriteLine($"Circle S >{s}:\n");
                for (int i = 0; i < cr.Length; i++)
                {
                    if(eq(cr[i]))
                    {
                        Console.WriteLine(cr[i].ToString());
                        crore++;
                    }
                }
                Console.WriteLine($"Количество {crore}");


                Console.WriteLine("To exit escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }

        private static void IRead(out double s)
        {
            try
            {
                s = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {            
                Console.WriteLine(e.Message);
                IRead(out s);
            }
        }
    }
}

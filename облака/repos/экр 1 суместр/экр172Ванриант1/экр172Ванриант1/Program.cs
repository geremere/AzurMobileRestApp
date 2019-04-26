using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Ванриант1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Random rnd = new Random();
                string[] name = new string[3];
                name[0] = "iphone";
                name[1] = "lenovo";
                name[2] = "Yandex";
                List<Gadget> gd = new List<Gadget>();
                for (int i = 0; i < 30; i++)
                {
                    if (rnd.Next(0, 2) == 1)
                        gd.Add(new Router(rnd.Next(100, 1000), name[rnd.Next(0, 3)]));
                    else
                    {
                        string number="";
                        for (int j = 0; j < 8; j++)
                        {
                            number += rnd.Next(0, 9);
                        }
                        gd.Add(new Smartphone(rnd.Next(100, 1000), name[rnd.Next(0, 3)],number));
                    }
                }
                Store st = new Store(gd);
                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ralli;

namespace ересдачаэкр172
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Random rnd = new Random();
                int widht = rnd.Next(10, 31);
                Car[] car = MassiveCreator(widht,rnd);
                ConsoleKeyInfo step;
                Console.WriteLine("spacebar");
                Console.WriteLine("Гонка началась");
                bool flag = true;
                int i = 0,win=0;
                do
                {
                    Console.WriteLine("Нажимайте пробел");
                    step = Console.ReadKey(true);
                    if (step.Key == ConsoleKey.Spacebar)
                    {
                        if (i > 4) i = 0; 
                        car[i].Step();
                        if (car[i].X >= widht-1)
                        {
                            win = i;
                            flag = false;
                        }
                        else
                        {
                            car[i].PrintOnMap(widht);
                            i++;
                        }
                    }
                } while (flag);
                Console.WriteLine($"Winner:{car[win].Name}");


                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }

        private static Car[] MassiveCreator(int widht, Random rnd)
        {
            Car[] car = new Car[5];
            for (int i = 0; i < car.Length; i++)
            {   
                string name=CreateName(rnd);
                if(rnd.Next(0,2)==0)
                {
                    car[i] = new SpeedCar(name);
                    car[i].PrintOnMap(widht);
                }
                else
                {
                    car[i] = new SlowCar(name);
                    car[i].PrintOnMap(widht);
                }
            }
            return car;
        }

        private static string CreateName(Random rnd)
        {
            string name = "";
            name += (char)rnd.Next(65, 91);
            for (int i = 0; i < 4; i++)
            {
                name += (char)rnd.Next(98, 124);
            }
            return name;
        }
    }
}

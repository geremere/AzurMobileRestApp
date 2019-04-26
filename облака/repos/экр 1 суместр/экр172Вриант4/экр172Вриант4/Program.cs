using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Вриант4
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo exit;
            do
            {
                main();
                

                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }

        private static void main()
        {
            Random rnd = new Random();
            int power;
            int mass;
            try
            {
                Console.WriteLine("Введите грузоподемность поезда");
                power = int.Parse(Console.ReadLine());
                if (power <= 0) throw new FormatException();
                Console.WriteLine("Введите массу пустого вагона");
                mass = int.Parse(Console.ReadLine());
                if (mass <= 0) throw new FormatException();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Train tr = new Train(mass, power);

            tr.Connect(new CargoWagon(mass, rnd.Next(20, 36), rnd.Next(2, 10)));
            Console.WriteLine(tr.Mass);
        }
    }
}

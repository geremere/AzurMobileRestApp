using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace экэрваринат1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Random rnd = new Random();
                FoodBasket[] FBI = CreateMasive(rnd);
                PrintBaskets(FBI);
                double MaxBasketCoast=MaxBasketCost(FBI);
                Console.WriteLine($"\nMaxBasketCost= {MaxBasketCoast:f2}");
                Console.WriteLine("To exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }

        private static double MaxBasketCost(FoodBasket[] FBI)
        {
            double[] costs = new double[FBI.Length];
            for (int i = 0; i < costs.Length; i++)
            {
                costs[i] = FBI[i].BasketCost();
            }
            return costs.Max();
        }

        private static void PrintBaskets(FoodBasket[] FBI)
        {
            for (int i = 0; i < FBI.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(FBI[i][j]);
                }
            }
        }

        private static FoodBasket[] CreateMasive(Random rnd)
        {
            FoodBasket[] FBI = new FoodBasket[rnd.Next(10, 16)];
            for (int i = 0; i < FBI.Length; i++)
            {
                if (rnd.Next(1, 100) < 60)
                {
                    Item[] food = new Food[8];
                    for (int j = 0; j < 8; j++)
                    {
                        string name = CreateRandomName(rnd);
                        food[j] = new Food(name, rnd.Next(29, 2999) + rnd.NextDouble(), rnd.Next(5, 15));
                    }
                    FBI[i] = new FoodBasket(food, 8);
                }
                else
                {
                    Item[] drink = new Drink[8];
                    for (int j = 0; j < 8; j++)
                    {
                        string name = CreateRandomName(rnd);
                        drink[j] = new Drink(name, rnd.Next(29, 2999) + rnd.NextDouble(), rnd.Next(1, 9));
                    }
                    FBI[i] = new FoodBasket(drink, 8);
                }
            }
            return FBI;
        }

        private static string CreateRandomName(Random rnd)
        {
            string name = "";
            for (int i = 0; i < rnd.Next(1,10); i++)
            {
                name += (char)rnd.Next(95, 121);
            }
            return name;
        }
    }
}

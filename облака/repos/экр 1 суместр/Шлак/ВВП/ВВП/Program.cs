using System;

namespace ВВП
{
    class Program
    {
        static double sum = 0;
        public static void TotalCost(AbsractClassViewer view, double visit, double cost)
        {
            for (int i = 1; i <= visit; i++)
            {
                view.Visit();
                sum += view.Cost(cost);
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {

                AbsractClassViewer view = new StudentViewer();
                double visit = 9;
                double cost = 100;
                TotalCost(view,visit,cost);
                Console.WriteLine(sum);
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);
        }
    }
}

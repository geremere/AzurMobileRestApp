using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        public static uint ReadK()
        {
            string line;
            uint res;
            do
            {
                Console.WriteLine("введите целое положитлеьное число K");
                line = Console.ReadLine();
            } while (!uint.TryParse(line, out res));
            return res;
        }
        public static double ReadX0()
        {
            string line;
            double res;
            do
            {
                Console.WriteLine("введите целое положитлеьное число x0");
                line = Console.ReadLine();
            } while (!double.TryParse(line, out res));
            return res;
        }
        public static bool Summ(double X0,uint K,ref double S)
        {
            if ((X0<7)&&(X0>(-7)))
            {
                uint n = 1;
                int sgn = 1;
                double s1=1,q=1,z=1 ;
                do
                {
                    q = q / 7;
                    z = z / X0;
                    s1 = (n * n * q) / (z * (n + 1));
                    S += s1;
                    n++;
                    if (s1 < 0) sgn = -1;
                    if (s1 > 0) sgn = 1;
                    s1 *= sgn;
                     
                } while (s1>double.Epsilon);
                return true;
            }
            else
            {
                double s1,z=1,q=1;
                for(int n=1;n<=K;n++)
                {
                    q = q / 7;
                    z = z / X0;
                    s1 = (n * n * q) / (z * (n + 1));
                    S += s1;                   
                }
                return false;
            }
        }
        public static void Print(double X0,uint K, double S)
        {
            if ((X0<7)&&(X0>(-7)))
            {
                Console.WriteLine("summ({0:f4})={1:f4}",X0,S);
            }
            else
            {
                Console.WriteLine(K);
                Console.WriteLine("summ({0:f4})={1:f4}", X0, S);
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                uint K = ReadK();
                double X0 = ReadX0();
                double S = 0;
                bool logic = Summ(X0,K,ref S);
                Print(X0,K,S);
                Console.WriteLine("escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);

        }
    }
}

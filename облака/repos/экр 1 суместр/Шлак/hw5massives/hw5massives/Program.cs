using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5massives
{
    class Program
    {
        public static int Reader()
        {
            string line;
            int res;
            do
            {
                Console.Write("введите длину массства n: ");
                line = Console.ReadLine();

                if (!int.TryParse(line, out res)) Console.WriteLine("ошибка ввода");

                    Console.WriteLine();
            } while (!int.TryParse(line, out res));
            return res;
        }
        public static void ArrayCreater(int n,int[] ar1, int[] ar2)
        {
            Random rnd = new Random();
            for (int i=0;i<n;i++)
            {
                ar1[i] = rnd.Next(10,51);
                ar2[i] = rnd.Next(10, 51);              
            }
        }
        public static void Printar1(int n,int[] ar1)
        {
            Console.WriteLine("Массив ar1:");
            for (int i=0;i<n;i++)
            {
                Console.Write("{0} ",ar1[i]);
            }
            Console.WriteLine();
        }
        public static void Printar2(int n, int[] ar2)
        {
            Console.WriteLine("Массив ar2:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", ar2[i]);
            }
            Console.WriteLine();
        }
        public static void newar2(int k,int[] ar2, int[] ar1)
        {
            for (int i=0;i<ar2.Length;i++)
            {
                if (ar2[i]%2==0)
                {
                    k++;
                    ar1[k] = ar2[i];
                }
            }
        }
        public static void Printnewar1(int k,int[] ar1,int[] ar2)
        {
            Console.WriteLine("Массив resar1:");
            for (int i = 0; i <ar1.Length; i++)
            {
                if (ar1[i]!=0)
                Console.Write("{0} ", ar1[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo z;
            do
            {

                int n = Reader();
                int k = n;
                int[] ar1 = new int[2 * n];
                int[] ar2 = new int[n];
                ArrayCreater(n, ar1, ar2);
                Printar1(n, ar1);
                Printar2(n, ar2);
                newar2(k, ar2, ar1);
                Printnewar1(k,ar1, ar2);

                z = Console.ReadKey(true);
            } while (z.Key != ConsoleKey.Escape);
        }
    }
}

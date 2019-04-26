using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        public static int Read(string text)
        {
            string line;
            int res;
            do
            {
                Console.WriteLine("введите {0}", text);
                line = Console.ReadLine();
                if ((!int.TryParse(line, out res)) || (res <= 0)) Console.WriteLine("ошибка ввода");
            } while ((!int.TryParse(line, out res))||(res<=0));
            return res;
        }//метод ввода N и K
        public static void CreateArray(int[] A, ref Random rnd)
        {
            for (int i=0;i<A.Length;i++)
            {
                A[i] = rnd.Next(-1, 2);
            }
        }// метод создания массива А
        public static void ShowArray1(int[] A)
        {
            Console.WriteLine("array A:");
            for (int i = 0; i<A.Length;i++)
            {
                Console.Write("{0}  ",A[i]);
                if (i % 10 == 9) Console.WriteLine();
                
            }
            Console.WriteLine();
        }//метод вывода массива А
        public static void ShowArra2(int[] B)
        {
            Console.WriteLine("Array B: ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("{0}  ", B[i]);
                if (i % 10 == 9) Console.WriteLine();


            }
            Console.WriteLine();
        }//метод вывода массива В
        public static void MegaArray(int[] A, int[] B, int[] C)
        {
            Console.WriteLine("Array C: ");
            for (int i=0;i<C.Length;i++)
            {
                if(C.Length==B.Length)
                {

                    if (i % 2 != 0)
                        C[i] = B[i];

                    if ((i < A.Length)&&(i%2==0))
                        C[i] = A[i];

                    if ((i > A.Length) && (i % 2 == 0))
                        C[i] = 0;
                }
                if (C.Length == A.Length)
                {

                    if (i % 2 == 0)
                        C[i] = A[i];

                    if ((i < B.Length)&&(i%2!=0))
                        C[i] = B[i];
                    
                    if ((i > B.Length) && (i % 2 != 0))
                        C[i] = 0;
                }
                Console.Write("{0} ", C[i]);
            }
            Console.WriteLine();
        }//метод создания и вывода массива С
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Random rnd = new Random();
                int N = Read("целое положительное число N");
                int K = Read("целое полжительное число K");
                int[] A = new int[N];
                int[] B = new int[K];
                CreateArray(A, ref rnd);
                CreateArray(B, ref rnd);
                ShowArray1(A);
                ShowArra2(B);
                int max =Math.Max(N, K);
                int[] C = new int[max];
                MegaArray(A, B, C);
                Console.WriteLine("для выхода нажмите escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);//цикл решения
        }
    }
}

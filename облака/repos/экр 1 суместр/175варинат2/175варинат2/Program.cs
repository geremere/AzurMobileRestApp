using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _175варинат2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Random rnd = new Random();
                Matrix mtr1 = new Matrix(rnd.Next(3, 7), rnd.Next(3, 7));
                Console.WriteLine(mtr1.ToString());
                Matrix mtr2 = new Matrix(rnd.Next(3, 7), rnd.Next(3, 7));
                Console.WriteLine(mtr2.ToString());
                MatrixOperation[] operations = new MatrixOperation[rnd.Next(4, 8)];
                for (int i = 0; i < operations.Length; i++)
                {
                    if(rnd.Next(1,9)<4)
                    {
                        operations[i] = new SumOperation();
                    }
                    else
                    {
                        operations[i] = new TransposeOperation();
                    }
                    try
                    {
                        mtr1 = operations[i].PerformOperation(mtr1, mtr2);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("не подходящие размерности матрицы");
                    }
                    catch(StackOverflowException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine(mtr1.ToString());
                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Square
    {
        Random rnd = new Random();
        int[,] matrix;
        public Square(int n)
        {
            matrix = new int[n, n];
            MatrixCreator();
            Print();
        }

        private void MatrixCreator()
        {

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = rnd.Next(0, 101);
                        sum += matrix[i, j];
                    }                   
                }
            }


            int sum2 = sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i+j==matrix.GetLength(0)-1)
                    {
                        if (i == j)
                            sum2 -=matrix[i,j];

                        else
                        {
                            matrix[i, j] = rnd.Next(0, sum2);
                            sum2 -= matrix[i, j];
                        }

                        if ((j == (matrix.GetLength(1) - 1)) && (sum2 != 0) && (i == (matrix.GetLength(0) - 1)))
                        {
                            matrix[i, j] += sum2;
                            sum2 -= matrix[i, j];
                        }
                    }
                }
            }
        }

        private void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;  j < matrix.GetLength(1);  j++)
                {
                    Console.Write($"{matrix[i, j],3}  ");                   
                }
                Console.WriteLine();
            }

        }
    }
}

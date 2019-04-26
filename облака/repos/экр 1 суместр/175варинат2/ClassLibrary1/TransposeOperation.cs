using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TransposeOperation : MatrixOperation
    {
        public Matrix PerformOperation(Matrix a)
        {
            Matrix matrix = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.M; j++)
                {
                    if (a[j, i] > 0)
                        matrix[i, j] = a[j, i] * 1.08;
                    else
                        matrix[i, j] = a[j, i];
                }
            }
            return matrix;
        }

        public override Matrix PerformOperation(Matrix a, Matrix b)
        {
            Matrix matrix = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.M; j++)
                {
                    matrix[i, j] = a[j, i];
                    OperationComplexity += 3;
                }
            }
            return matrix;
        }
    }
}

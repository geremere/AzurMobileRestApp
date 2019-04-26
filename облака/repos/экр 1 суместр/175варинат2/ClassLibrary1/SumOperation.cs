using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SumOperation : MatrixOperation
    {        
        public override Matrix PerformOperation(Matrix a, Matrix b)
        {
            if (a.N != b.N || a.M != b.M) throw new ArgumentException();// ctahc exception
            Matrix matrix = new Matrix(a.N,a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.M; j++)
                {
                    matrix[i,j] = a[i, j] + b[i, j];
                    OperationComplexity++;
                }
            }
            return matrix;
        }
    }
}

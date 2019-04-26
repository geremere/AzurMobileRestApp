using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Matrix
    {
        Random rnd = new Random();
        public int N { get; }
        public int M { get; }
        double[][] matrix;
        public Matrix(int n, int m)
        {
            N = n;
            M = m;
            matrix= new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = rnd.Next(-10, 9)+rnd.NextDouble();
                }
            }
        }

        public double this[int n, int m]
        {
            get
            {
                return matrix[n][m];
            }
            set
            {
                matrix[n][m] = value;
            }
        }

        public override string ToString()
        {
            string mtr = "";
            foreach  (double[] i in matrix)
            {
                foreach (double j in i)
                {
                    mtr += $"{j:f3}  ";
                }
                mtr += "\n";
            }
            return mtr; 
        }



    }
}

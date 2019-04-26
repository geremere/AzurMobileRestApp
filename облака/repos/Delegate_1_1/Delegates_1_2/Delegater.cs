using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1_2
{
    
    public class Delegater
    {
       public delegate int[] Mass(int n);
       public Mass arr = n => { return new int[n]; };
       public delegate void Method(int[] arr);
       public Method newmet = arr => 
        {
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = k++;
            }
        };
    }
}

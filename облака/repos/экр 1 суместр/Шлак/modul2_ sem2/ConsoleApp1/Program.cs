using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] arr = new int[count];
            arr[0] = 2;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 2;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int count = 3;
            int[] array = GetFirstEvenNumbers(count);
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}

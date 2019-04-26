using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        public static uint Read()
        {
            string line;
            uint res;
            do
            {
                Console.Write("vvedi value: ");
                line = Console.ReadLine();
            } while (!uint.TryParse(line, out res));
            return res;
        }
        public static void ArrayCreater(List<uint> arr)
        {
            int i = 0;

            arr.Add(Read());
            Console.WriteLine("{0} ", arr[i]);
            while (arr[i] != 1)
            {
                ++i;
                arr.Add((arr[i - 1] % 2 == 0 ? arr[i - 1] / 2 : (3 * arr[i - 1] + 1)));
                Console.WriteLine("{0} ", arr[i]);
            }
        }
        static void Main(string[] args)
        {
            List<uint> arr = new List<uint>();
            ArrayCreater(arr);
        }
    }
}

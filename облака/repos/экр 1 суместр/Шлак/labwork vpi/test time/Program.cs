using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace test_time
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Timer tmr = new Timer();
                tmr.Interval = 5000;
                tmr.Start();

                string line = Console.ReadLine();
                Console.WriteLine(line);

            }

        }
    }
}
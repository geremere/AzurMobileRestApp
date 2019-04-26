using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A
    {
        public void Do()
        {
            Console.WriteLine(Program.rnd.Next());
        }
    }

       
    class Program
    {
        public static Random rnd;

        static void Main(string[] args)
        {
            rnd = new Random();
            (new A()).Do();
            Console.WriteLine(rnd.Next());
            Console.Read();
        }
    }
}

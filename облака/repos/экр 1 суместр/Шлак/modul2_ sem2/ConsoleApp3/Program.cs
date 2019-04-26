using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class StringExtension
    {
	    public static int ToInt(this string str)
        {
            int res = 0; 
           if ( int.TryParse(str, out res))
            return  res;

            throw new Exception("");
        }
    }
    class Program
    {
        public static void Main()
        {
            var arg1 ="100500";
            Console.Write(arg1.ToInt() + "42".ToInt());
            Console.Read();
        }
    }
}

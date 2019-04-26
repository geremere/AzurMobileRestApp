using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[2];
            str[0] = Console.ReadLine();
            str[1] = Console.ReadLine();
            Converter cnv = new Converter();
            ConvertRule CR0 = RemoveDigits;
            ConvertRule CR1 = RemoveSpaces;
            Console.WriteLine(cnv.Convert(str[0],CR0));
            Console.WriteLine(cnv.Convert(str[1], CR0));
            Console.WriteLine(cnv.Convert(str[0], CR1));
            Console.WriteLine(cnv.Convert(str[1], CR1));
            Console.Read();
        }

        public static string RemoveDigits(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    str = str.Remove(i,1);
                    i--;
                }
                
            }
            return str;
        }

        public static string RemoveSpaces(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    str = str.Remove(i,1);
                    i--;
                }
            }
            return str;
        }
    }
    public delegate string ConvertRule(string s);

    class Converter
    {
        public string Convert(string str,ConvertRule cr)
        {
            return cr(str);
        }
    }
}

using System;

namespace Финтех
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                string str = $"{i}";
                if (str.Length == 1) s++;
                else
                {
                    for (int j = 0; j < str.Length/2; j++)
                    {
                        if (str[j] == str[str.Length - 1 - j])
                            s++;
                    }
                }
            }
            Console.WriteLine(s);
            Console.Read();

        }
    }
}

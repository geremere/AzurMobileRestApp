using System;


namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            for (int i = 0; i < line.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < line.Length; j++)
                {
                    if (i != j && line[i] == line[j])
                    {
                        Console.Write(line[i]);
                        flag= true;
                        break;

                    }
                }
                if (flag) break;
            }
            Console.Read();
        }
    }
}

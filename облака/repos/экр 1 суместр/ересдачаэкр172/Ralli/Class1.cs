using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ralli
{
    public abstract class Car
    {
        protected Random rnd = new Random();
        int x=0;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        char symbol;
        public abstract char Symbol { get; }

        public abstract void Step();

        public void PrintOnMap(int widht)
        {
            char[] field = new char[widht];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = '-';
            }
            field[X] = Symbol;
            Console.Write($"{Name}:");
            foreach(var i in field)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }


    }
}

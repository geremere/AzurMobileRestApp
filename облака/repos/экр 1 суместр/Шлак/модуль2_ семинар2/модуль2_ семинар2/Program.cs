using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модуль2__семинар2
{
    class Fraction
    {
        private int a, b;
        public Fraction()
        {
            a = 0;
            b = 1;
        }

        public Fraction(int other)
        {
            a = other;
            b = 1;
        }

        private int gcd(int a, int b)
        {
            int c;
            while (a != 0)
            {
                c = a;
                a = b % a;
                b = c;
            }
            return b;
        }

        public Fraction(int na, int nb)
        {
            a = na;
            b = nb;
            int g = gcd(Math.Abs(a), Math.Abs(b));
            a = a / g;
            b = b / g;
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
        }

        public override string ToString()
        {
            if (b == 1)
            {
                return a.ToString();
            }
            return a.ToString() + "/" + b.ToString();
        }

        static public Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.a * right.b + right.a * left.b, left.b * right.b);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Fraction fac = new Fraction(1), dac = new Fraction(3);
            Console.Write((fac + dac).ToString());
            Console.ReadKey();
        }
    }
}

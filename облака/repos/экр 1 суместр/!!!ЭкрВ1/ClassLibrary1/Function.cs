using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLib
{
    public abstract class Function
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Language(value)) throw new ArgumentException();
                name = value;
            }
        }
        protected double b;
        public abstract double B { get; set; }
        protected double c;
        public abstract double C { get; set; }

        double a;

        protected Function(string name, double b, double c, double a)
        {
            checked
            {
                Name = name;
                B = b;
                C = c;
                A = a;
            }
        }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }


        private bool Language(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 65 || value[i] > 122 || (value[i] > 90 && value[i] < 97)) return true;
            }
            return false;

        }

        public abstract double this[double x] { get; }

        public override string ToString()
        {
            return $"Function: {Name}\n Coefficient A: {A}, B: {B}, C: {C}.";
        }
    }
}

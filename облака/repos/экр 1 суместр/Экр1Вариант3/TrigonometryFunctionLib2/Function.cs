using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometryFunctionLib2
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
                if (Languageckeck(value)) throw new ArgumentException("Допускается последовательность только из букв латинского алфавита");
                name = value;
            }
        }

        protected double b;
        public abstract double B { get; set; }
        double a;
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

        double c;

        protected Function(string name, double b, double a, double c)
        {
            Name = name;
            B = b;
            A = a;
            C = c;
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public abstract double this[double x] { get; }
        public override string ToString()
        {
            return $"Функция: {Name}.\n Коэффициенты: A = {A:f3}, B = {B:f3}, C = {C:f3}.";
        }

        private bool Languageckeck(string value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 65 || value[i] > 122 || (value[i] > 90 && value[i] < 97)) return true;
            }
            return false;
        }
    }
}

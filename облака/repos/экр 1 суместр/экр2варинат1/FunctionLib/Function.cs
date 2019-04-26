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
                if (EnglandWords(value)) throw new FunctionLibArgumentException();
                name = value;
            }
        }

        int a;
        public int A
        {
            get
            {
                return a;
            }
        }
        int b;
        public int B
        {
            get
            {
                return b;
            }
        }
        int c;
        public int C
        {
            get
            {
                return c;
            }
        }


        protected Function(string name, int a, int b, int c)
        {
            checked
            {
                Name = name;
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public abstract double this[double x] { get; }


        /// <summary>
        /// проверяет есть ли не английские буквы
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool EnglandWords(string value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 65 || value[i] > 122 || (value[i] > 90 && value[i] < 97)) return true;
            }
            return false;
        }

        public double this[int start, int end]
        {
            get
            {
                double res=0;
                for (int i = start; i < end-1; i++)
                {
                    checked
                    {
                        res += (this[i] + this[i + 1]) / 2;
                    }
                }
                return res;
            }
        }
        public override string ToString()
        {
            return $"Function: {Name}.\n Coefficient: A = {A}, B = {B}, C = {C}";
        }
    }
}

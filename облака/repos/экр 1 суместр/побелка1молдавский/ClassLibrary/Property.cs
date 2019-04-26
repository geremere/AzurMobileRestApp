using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Property
    {
        protected Random rnd = new Random();

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Language(value)) throw new FunctionLibException("только латинские буквы");
                name = value;
            }
        }
        double increase;
        double taxRate;
        public double Increase
        {
            get
            {
                return increase;
            }
            set
            {
                if (value < 1) throw new FunctionLibException("Increase >=1");
                increase = value;
            }
        }

        public double TaxRate
        {
            get
            {
                return taxRate;
            }
            set
            {
                if (value > 1|| value <=0) throw new FunctionLibException("0 < TaxRate < 1");
                taxRate = value;
            }
        }
        protected int tenure;

        protected Property(string name, double increase, double taxRate, int tenure)
        {
            Name = name;
            Increase = increase;
            TaxRate = taxRate;
            Tenure = tenure;
        }

        public abstract int Tenure { get; set; }
        public abstract double this[int x] { get; }

        public override string ToString()
        {
            return $"Имущество: {Name}\nКоэффициент увеличения налога: {Increase}\n" +
                $"Процентная ставка налога: {TaxRate}\nЧисло месяцев владения обьектом: {Tenure}\n";
        }

        private bool Language(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 'A' || value[i] > 'z' || (value[i] > 'Z' && value[i] < 'a')) return true;
            }
            return false;
        }
    }
}

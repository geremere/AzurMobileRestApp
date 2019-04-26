using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLib
{
    public abstract class Property
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
                if (LanguageEngland(value)) throw new ArgumentException("England words");//catch
                name = value;
            }
        }

        double increase;
        public double Increase
        {
            get
            {
                return increase;
            }
            set
            {
                if (value < 1) throw new ArgumentException("Increase>=1");//cactch
                increase = value;
            }
        }

        protected double taxRate;
        public abstract double TaxRate { get; set; }
        int tenure;

        protected Property(string name, double increase, double taxRate, int tenure)
        {
            Name = name;
            Increase = increase;
            TaxRate = taxRate;
            Tenure = tenure;
        }

        public int Tenure
        {
            get
            {
                return tenure;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Tenure>0");//cathc
                tenure = value;
            }
        }

        public abstract double this[int cost] { get; }
        public override string ToString()
        {
            return $"Имущество: {Name}.\n Коэффициент увеличения налога: {Increase}.\nПроцентная ставка: {TaxRate}\n" +
                $"Число месяцев владения обьектом: {Tenure}";
        }



        /// <summary>
        /// проверяет являются ли все символы именя буквами англиского алфавита
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool LanguageEngland(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 65 || value[i] > 122 || (value[i] > 90 && value[i] < 97)) return true;
            }
            return false;
        }
    }
}

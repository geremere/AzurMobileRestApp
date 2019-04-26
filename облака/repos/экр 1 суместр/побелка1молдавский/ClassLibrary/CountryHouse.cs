using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CountryHouse:Property
    {
        public CountryHouse(string name, double increase, double taxRate, int tenure) : base(name, increase, taxRate, tenure)
        {
        }

        public override double this[int x]
        {
            get
            {
                if (x <= 0) throw new ArgumentException("Цена может быть только положительной");
                if (rnd.Next(1, 11) > 2)
                {
                    if (Tenure == 0) throw new DivideByZeroException("Tenure!=0");
                    if (Increase * TaxRate * (x / Tenure) < 0) throw new ArgumentException("Налог не может быть отрицательным");
                    return Increase * TaxRate * (x / Tenure);
                }
                else
                {
                    if (Tenure == x) throw new ArgumentException("Tenure!= cost(Ln(0) not exist)");
                    if (Increase * TaxRate + Math.Log(x - Tenure) < 0) throw new ArgumentException("Налог не может быть отрицательным");
                    return Increase * TaxRate + Math.Log(x - Tenure);
                }
            }
        }

        public override int Tenure
        {
            get
            {
                return tenure;
            }
            set
            {
                if (value <= 0) throw new FunctionLibException("Tenure>0");
                tenure = value;
            }
        }

        public override string ToString()
        {
            return $"Вид: CountryHouse" + base.ToString();
        }
    }
}

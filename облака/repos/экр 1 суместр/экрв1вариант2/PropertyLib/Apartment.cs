using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLib
{
    public class Apartment : Property
    {
        public Apartment(string name, double increase, double taxRate, int tenure) : base(name, increase, taxRate, tenure)
        {
        }

        public override double this[int cost]
        {
            get
            {
                if (cost <= 0) throw new ArgumentException("Cost>0");
                return Increase * TaxRate * Math.Log(cost / Tenure);
            }
        }

        public override double TaxRate
        {
            get
            {
                return taxRate;
            }
            set
            {
                if (value > 0.4 && value>0) throw new ArgumentException("0<TaxRate<0,4");
                taxRate = value;

            }
        }
        public override string ToString()
        {
            return "Вид: Apartment\n"+base.ToString();
        }
    }
}

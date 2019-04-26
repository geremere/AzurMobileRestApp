using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Apartment : Property
    {
        public Apartment(string name, double increase, double taxRate, int tenure) : base(name, increase, taxRate, tenure)
        {
        }

        public override double this[int x]
        {
            get
            {
                if (x <= 0) throw new ArgumentException("Цена может быть только положительной");
                if(rnd.Next(1,11)>3)
                {
                    if (Increase * TaxRate * Math.Log(x / Tenure) < 0) throw new ArgumentException("Налог не может быть отрицательным");
                    return Increase * TaxRate * Math.Log(x / Tenure);
                }
                else
                {
                    if (Double.Equals(TaxRate % 180 - 90, Double.Epsilon)) throw new ArgumentException("TaxRate!=90(Tan(90) не существует)");
                    if (Increase * TaxRate * Math.Log(x / Tenure) - Math.Abs(1 / Math.Tan(TaxRate * Math.PI / 180)) < 0) throw new ArgumentException("Налог не может быть отрицательным");
                    return Increase * TaxRate * Math.Log(x / Tenure) - Math.Abs(1 / Math.Tan(TaxRate*Math.PI/180));
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
            return $"Вид: Apartment" + base.ToString();
        }
    }
}

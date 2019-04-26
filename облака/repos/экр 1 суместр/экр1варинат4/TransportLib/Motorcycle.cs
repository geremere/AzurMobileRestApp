using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLib
{
    public class Motorcycle : Transport
    {
        public Motorcycle(string name, int fuelTankCapacity, double fuelMileage, double miles) : 
            base(name, fuelTankCapacity, fuelMileage, miles)
        {
        }

        public override int this[double miles]
        {
            get
            {
                if (miles <= 0) throw new ArgumentException("Расстояние не может быть меньше нуля или равно ему");
                int capacity=1;
                double value = miles * FuelMileage / 100;
                do
                {
                    value -= FuelTankCapacity;
                    capacity++;
                } while (value > 0);
                //capacity += (int)(value/FuelTankCapacity)+1;
                return capacity;
            }
        }

        public override int FuelTankCapacity
        {
            get
            {
                return fueltankCapacity;
            }
            set
            {
                if (value < 5) throw new ArgumentException("Минмальный обьем бензобака мотоцикла 5л");
                fueltankCapacity = value;
            }
        }
        public override double FuelMileage
        {
            get
            {
                return fuelMileage;
            }
            set
            {
                if (value > 15) throw new ArgumentException("Расход мотоцикла на 100км не может быть больше 15л");
                fuelMileage = value;
            }
        }

        public override string ToString()
        {
            return "Вид транспортного средства: Motorcycle\n" + base.ToString();
        }
    }
}

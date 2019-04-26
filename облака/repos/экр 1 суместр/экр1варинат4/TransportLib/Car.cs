using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLib
{
    public class Car:Transport
    {
        protected Random rnd = new Random();
        public Car(string name, int fuelTankCapacity, double fuelMileage, double miles) :
            base(name, fuelTankCapacity, fuelMileage, miles)
        {
        }

        public override int this[double miles]
        {
            get
            {
                if (miles <= 0) throw new ArgumentException("Расстояние не может быть меньше нуля или равно ему");
                int capacity = 1;
                double value = miles * FuelMileage / 100;
                do
                {
                    value -= FuelTankCapacity;
                    capacity++;
                } while (value > 0);
                // += (int)(value / FuelTankCapacity)+1;
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
                if (value < 10) throw new ArgumentException("Минмальный обьем бензобака машины 10л");
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
                if (value > 30) throw new ArgumentException("Расходмашины на 100км не может быть больше 30л");
                if (x == value) throw new ArgumentException("miles = FuelMileage");
                if (rnd.Next(1, 11) < 3)
                {
                    if (value + Math.Log(x - value) <= 30)
                        fuelMileage = value + Math.Log(x - value);
                }
                else
                    fuelMileage = value;
            }
        }

        public override string ToString()
        {
            return "Вид транспортного средства: Transport\n" + base.ToString();
        }
    }
}

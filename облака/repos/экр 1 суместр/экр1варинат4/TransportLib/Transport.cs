using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLib
{
    public abstract class Transport
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
                if (Englandcheker(value)) throw new ArgumentException("Допускается последовательность только из букв латинского алфавита");
                name = value;
            }
        }
        protected int fueltankCapacity;
        public abstract int FuelTankCapacity { get; set; }

        protected double fuelMileage;
        protected double x;

        protected Transport(string name, int fuelTankCapacity, double fuelMileage, double miles)//+1 argument
        {
            x = miles;
            Name = name;
            FuelTankCapacity = fuelTankCapacity;
            FuelMileage = fuelMileage;
        }

        public abstract double FuelMileage { get; set; }

        public abstract int this[double miles] { get; }

        public override string ToString()
        {
            return $"Транспортное средство: {Name}.\nОбьем бензобака: {FuelTankCapacity}л.\n" +
                $"Расход бензина: {FuelMileage:f3}л.\n";
        }

        private bool Englandcheker(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < 65 || value[i] > 122 || (value[i] > 90 && value[i] < 97)) return true;
            }
            return false;
        }
    }
}

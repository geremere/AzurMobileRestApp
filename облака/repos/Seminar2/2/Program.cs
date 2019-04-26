using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Car
    {
        // Информация о внутреннем состоянии
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        // Машина работоспособна?
        private bool carIsDead;
        // Конструкторы
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }
}

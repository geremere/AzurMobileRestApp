using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Ванриант1
{
    public class Smartphone : Gadget
    {
        string phoneNumber;
        public string PhoneNumber { get { return phoneNumber; } }
        public Smartphone(int price, string manufacturer, string phoneNumber) : base(price, manufacturer)
        {
            this.phoneNumber = phoneNumber;
        }
        void Call(Smartphone another)
        {
            Console.WriteLine($"{ToString()}\n \n {another.ToString()}");
        }

        public override string ToString()
        {
            return $"phoneNumber: {phoneNumber}\n" +
                $"Price: {Price}\n" +
                $"Manufacturer: {Manufacturer}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Guitar : Instrument
    {
        public Guitar(int mastery, Random rnd)
        {
            this.mastery = mastery;
            volume = rnd.Next(4, 7) + rnd.NextDouble();
        }
        public override void Play()
        {
            Console.WriteLine($"Broohhhhhhm {volume:f3}");
        }

        public override string ToString()
        {
            return $"Mastery: {mastery}\tVolume: {volume:f3}";
        }
    }
}

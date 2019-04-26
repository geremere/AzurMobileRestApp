using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Drum : Instrument
    {
        public Drum(int mastery, Random rnd)
        {
            this.mastery = mastery;
            volume = rnd.Next(8, 9) + rnd.NextDouble();
        }

        public override void Play()
        {
            Console.WriteLine($"Booom {volume:f3}");
        }

        public override string ToString()
        {
            return $"Mastery: {mastery}\tVolume: {volume:f3}";

        }
    }
}

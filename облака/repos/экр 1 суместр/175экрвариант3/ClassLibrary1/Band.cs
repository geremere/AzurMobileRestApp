using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Band
    {
        Instrument[] band;
        public Instrument[] Bandd
        {
            get
            {
                return band;
            }
        }

        Random rnd = new Random((int)DateTime.Now.Millisecond);
        public Band()
        {
            band = new Instrument[rnd.Next(5, 13)];
            for (int i = 0; i < band.Length; i++)
            {
                if(rnd.Next(1,10)<3)
                {
                    band[i] = new Drum(rnd.Next(0,10), rnd);
                }
                else
                {
                    band[i] = new Guitar(rnd.Next(0, 10), rnd);
                }
            }
        }

        public void Play()
        {
            for (int i = 0; i < band.Length; i++)
            {
                if(band[i] is Guitar)
                {
                    band[i].Play();
                }
            }
            for (int i = band.Length-1; i >=0; i--)
            {
                if(band[i] is Drum)
                {
                    band[i].Play();
                }
            }
        }

        public double GetHowCoolBand()
        {
            double CoolRate = 0;
            for (int i = 0; i < band.Length; i++)
            {
                CoolRate += band[i].Mastery * band[i].Volume;
            }
            return CoolRate;
        }

        public Instrument this[int index]
        {
            get
            {
                return band[index];
            }
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < band.Length; i++)
            {
                res += $"{band[i].ToString()}\n";
            }
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Instrument
    {
        protected double volume;
        public double Volume
        {
            get
            {
                return volume;
            }            
        }
        protected int mastery;      

        public int Mastery
        {
            get
            {
                return mastery;
            }
        }

        public abstract void Play();

    }
}

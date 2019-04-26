using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Competition
    {
        List<Athlete> athlete;
        public List<Athlete> Athlete
        {
            get
            {
                return athlete;
            }
        }


        public Competition()
        {
            athlete=new List<Athlete>();
        }

        public void Add(Athlete athlete)
        {
            if (!athlete.IsOnDoping())
                this.athlete.Add(athlete);
            else throw new ArgumentException();//cacth please
        }

        public Runner GetWinners(ref Jumper bestJumper)
        {
            Runner winrun=null;
            bool flag = true;
            for (int i = 0; i < athlete.Count; i++)
            {
                if(athlete[i] is Runner)
                {
                    if(flag)
                    {
                        winrun = (Runner)athlete[i];
                        flag = false;
                    }
                    Runner run = (Runner)athlete[i];
                    if (run.Speed > winrun.Speed)
                        winrun = run;
   
                }
            }
            bool flagJ = true;
            for (int i = 0; i < athlete.Count; i++)
            {
                if(athlete[i] is Jumper)
                {
                    if(flagJ)
                    {
                        bestJumper =(Jumper) athlete[i];
                        flagJ = false;
                    }
                    Jumper jumper = (Jumper)athlete[i];
                    if (jumper.Distace > bestJumper.Distace)
                        bestJumper = jumper;
                }
            }
            return winrun;
        }

        public Athlete this[int index]
        {
            get
            {
                if (index < 0 || index > athlete.Count - 1) throw new ArgumentOutOfRangeException();
                    return athlete[index];
            }
        }

        public override string ToString()
        {
            string res="Competition\n";
            for (int i = 0; i < athlete.Count; i++)
            {
                res += $"{athlete[i].ToString()}\n";
            }
            return res;
        }
    }
}

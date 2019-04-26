using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВВП
{
    abstract class AbsractClassViewer
    {
        public double visits { get; set; }

        protected AbsractClassViewer()
            {
            visits = 0;
            }

        public void Visit()
        {
            visits++;
        }

        abstract public double Cost(double a);
    }

    class RegularViewer : AbsractClassViewer
    {
            public override double Cost(double a)
            {

                    double proc = 1 - ((visits-(visits%10)) / 10) * 0.01;

                    if (proc<0.8)
                    {
                        proc = 0.8;
                    }

                    return a * proc;
                             
            }
        
    }

    class StudentViewer : AbsractClassViewer
    {
            public override double Cost(double a)
            {
            if (visits%3==0)
                {
                return a * 0.5;
                }
            else
                {
                return a;
                }
            }
        

    }
}

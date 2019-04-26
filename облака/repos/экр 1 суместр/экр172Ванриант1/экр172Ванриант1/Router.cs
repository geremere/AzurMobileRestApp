using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Ванриант1
{
    public class Router : Gadget
    {
        int routerId;
        List<Gadget> gd;
        public Router(int price, string manufacturer) : base(price, manufacturer)
        {
        }

        void Connect (Gadget gadget)
        {
            for (int i = 0; i < gd.Count; i++)
            {
            }
            gd.Add(gadget);
        }

        void DisConnect(Gadget gadget)
        {
            gd.Remove(gadget);
        }

        public Gadget this[int index]
        {
            get
            {
                return gd[index];
            }
        }

        public override string ToString()
        {
            return $"routerId: {routerId}\n" +
                $"Price: {Price}\n" +
                $"Manufacturer: {Manufacturer}";
        }

    }
}

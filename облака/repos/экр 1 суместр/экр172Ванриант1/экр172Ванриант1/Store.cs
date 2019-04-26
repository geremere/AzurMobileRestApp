using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экр172Ванриант1
{
    class Store
    {
        List<Gadget> stock= new List<Gadget>();

        public Store(List<Gadget> stock)
        {
            this.stock = stock;
        }

        public List<Gadget> FindGadgets(int cheaperThan, string startWith, bool? isSmartphone)
        {
            List<Gadget> lg = new List<Gadget>();
            for (int i = 0; i < stock.Count; i++)
            {
                if(stock[i].Price<cheaperThan)
                {
                    string line = stock[i].Manufacturer.Substring(0, startWith.Length);
                    if (line==startWith||stock[i].Manufacturer=="")
                    {
                        if(isSmartphone==null)
                        {
                            lg.Add(stock[i]);
                        }
                        else
                        {
                            if((bool)isSmartphone)
                            {
                                lg.Add(stock[i]);
                            }
                        }
                    }
                }
            }
            return lg;
        }
    }
}

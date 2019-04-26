using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FoodBasket
    {
        Item[] Foodbasket;
        int size;

        public FoodBasket(Item[] foodbasket, int size)
        {
            Foodbasket = new Item[size];
            for (int i = 0; i < Foodbasket.Length; i++)
            {
                    Foodbasket[i] = foodbasket[i];//туть ошибка поймай
            }
        }

        public double BasketCost()
        {
            double cost = 0;
            for (int i = 0; i < Foodbasket.Length; i++)
            {
                cost += Foodbasket[i].Price;
            }
            return cost;
        }

        public Item this[int index]
        {
            get
            {
                return Foodbasket[index];
            }
        }
    }
}

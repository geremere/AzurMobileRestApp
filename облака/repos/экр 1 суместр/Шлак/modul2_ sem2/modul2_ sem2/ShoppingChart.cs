using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul2__sem2
{
    class ShoppingChart
    {
        private uint _itemCount;
        private uint _tatotalPrice;
        private uint _capatacity;
        private Item[] _cart;

        public ShoppingChart()
        {
            _capatacity = 3;
            _tatotalPrice = 0;
            _itemCount = 0;
            _cart = new Item[_capatacity];
        }

        

        public void AddToCart(Item item)
        {
            if (_itemCount == _capatacity)
                IncreaseSize();
            _cart[_itemCount] = item;
            _tatotalPrice += item.price * item.quantity;
            _itemCount++;
        }


        private void IncreaseSize()
        {
            Item[] temp = new Item[_capatacity + 3];
            for (int i = 0;  i < _capatacity; i++)
            {
                temp[i] = _cart[i];
            }
            _cart = temp;
            _capatacity += 3;
            
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _itemCount; i++)
            {
                s += _cart[i] + "\n";
            }
            s += _tatotalPrice;
            return s;

        }

    }
}

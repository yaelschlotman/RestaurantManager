using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class MenuItem
    {
        public MenuItem(string itemName, string itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
        public string ItemName { get; }

        public string ItemPrice { get; }
    }
}



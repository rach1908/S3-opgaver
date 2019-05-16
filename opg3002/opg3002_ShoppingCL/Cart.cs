using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace opg3002_ShoppingCL
{
    class Cart
    {
        private Item[] items;
        private DateTime when;
        public Cart()
        {
            When = DateTime.Now;
        }
        public DateTime When
        {
            get { return when; }
            set { when = value; }
        }

        public Item[] Items
        {
            get { return items; }
            set { items = value; }
        }

        public void addItem(Item item)
        {
            Items.ToList().Add(item);
        }

        public void removeItem(Item item)
        {
            Items.ToList().Remove(item);
        }

        public int getNumberOfItems()
        {
            return Items.Count();
        }

        public double getTotalPrice(Customer customer)
        {
            double returner = 0;
            foreach (var item in Items)
            {
                returner += item.CurrentPrice;
            }
            return returner;
        }

        public double getTotalDiscount(Customer customer)
        {
            return 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre.events.cons.events
{
    public class Inventory
    {
        //delegate => omschrijf de handler methode
        public delegate int ProductInventoryDelegate(object sender, EventArgs eventArgs);
        
        //declare an event
        public event ProductInventoryDelegate ProductInventoryEventEmpty;
        public event ProductInventoryDelegate ProductInventoryEventFull;

        public List<Product> Products { get; set; } = new List<Product>();

        public void BuyProduct()
        {
            Products.Add(new Product());
            if(Products.Count == 10)
            {
                ProductInventoryEventFull.Invoke(this, EventArgs.Empty);
            }
        }

        public void SellProduct()
        {
            //check if inventory == 0;
            if(Products.Count == 0)
            {
                //event must be fired/raised
                ProductInventoryEventEmpty.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Products.Remove(Products.Last());
            }

        }
    }
}

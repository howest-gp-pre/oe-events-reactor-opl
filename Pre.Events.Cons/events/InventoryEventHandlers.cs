using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre.events.cons.events
{
    public class InventoryEventHandlers
    {
        public int HandleInventoryEmpty(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Inventory emptied!");
            return 0;
        }
        public int HandleInventoryFull(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Inventory full!");
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management_System
{
    internal class Inventory_item
    {
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} \nQuantity :{quantity}\nPrice:{price}";
        }

    }
}

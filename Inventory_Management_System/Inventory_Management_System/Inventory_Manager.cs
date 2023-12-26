using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management_System
{
    internal class Inventory_Manager
    {
        public List<Inventory_item> inventory = new List<Inventory_item>();
        public void addItem(Inventory_item item)
        {
            inventory.Add(item);
            Console.WriteLine("Item added");
        }
        public void display()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("The inventory is empty ");
            }
            else
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void updateQuantity(string name, int quantity)
        {
            Inventory_item itemToUpadte = inventory.Find(i => i.Name == name);
            if (itemToUpadte != null)
            {
                itemToUpadte.quantity += quantity;
                Console.WriteLine("The quantity updated");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
        public void RemoveItem(string name)
        {
            Inventory_item itemToRemove = inventory.Find(i => i.Name == name);
            if (itemToRemove != null)
            {
                inventory.Remove(itemToRemove);
                Console.WriteLine("The item removed successfully");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}

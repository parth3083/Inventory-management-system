using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management_System
{
    internal class Program

    {
        static void addItem(Inventory_Manager invent)
        {
            Inventory_item item = new Inventory_item();
            Console.Write("Enter the item name : ");
            item.Name = Console.ReadLine();
            Console.Write("Enter the quanntity : ");
            string quanty_string = Console.ReadLine();
            int quanty = Convert.ToInt32(quanty_string);
            if (quanty != null)
            {
                item.quantity = quanty;
            }
            else
            {
                Console.WriteLine("Invalid quantity. The item added with 0 quantity");
            }
            Console.Write("Enter the price : ");
            string price_string = Console.ReadLine();
            double price = Convert.ToDouble(price_string);
            if (price != null)
            {
                item.price = price;
            }
            else
            {
                Console.WriteLine("Invalid quantity. The item added with 0 price.");
            }
            invent.addItem(item);
        }
        static void updateQuantity(Inventory_Manager invent)
        {
            invent.display();
            Console.Write("Enter the name of the item : ");
            string name = Console.ReadLine();
            Console.Write("Enter the quantity to add (positive) and to remove (negative) : ");
            string quanty_string = Console.ReadLine();
            int quanty = Convert.ToInt32(quanty_string);
            if (quanty != null)
            {
                invent.updateQuantity(name, quanty);
            }
            else
            {
                Console.WriteLine("Invalid quantity , item not updated !!!");
            }
        }
        static void RemoveItem(Inventory_Manager invent)
        {
            invent.display();
            Console.Write("Enter the name of the item that is to be removed : ");
            string name = Console.ReadLine();
            invent.RemoveItem(name);
        }
        static void Main(string[] args)
    {
        Inventory_Manager invent = new Inventory_Manager();
        while (true)
        {
            Console.WriteLine("*** Inventory Management System *** ");
            Console.WriteLine("1.Add Item");
            Console.WriteLine("2.Dislpay Item");
            Console.WriteLine("3.Update quantity of Item");
            Console.WriteLine("4.Remove Item");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice : ");
            string choice_string = Console.ReadLine();
            int choice = Convert.ToInt32(choice_string);
            switch (choice)
            {
                case 1:
                    {
                        addItem(invent);
                        break;
                    }
                case 2:
                    {
                        invent.display();
                        break;
                    }
                case 3:
                    {
                        updateQuantity(invent);
                        break;
                    }
                case 4:
                    {
                        RemoveItem(invent);
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option. Please enter again");
                        break;
                        }
            }

        }
        Console.ReadLine();

    }
}
}

using System;
using System.Collections.Generic;

namespace MenuOrderingSystem
{
    class Program
    {
        // Menu items and their prices
        static string[] menuItems = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
        static double[] menuPrices = { 2.5, 5.0, 3.0, 4.5, 8.0 };

        static List<string> itemPurchased = new List<string>();
        static List<int> itemQuantityPurchased = new List<int>();
        static List<double> priceOfItem = new List<double>();

        static void Main(string[] args)
        {
            bool continueOrdering = true;
            while (continueOrdering)
            {
                Console.WriteLine("Menu:");
                ShowMenu();

                Console.Write("Select the item number you want to order: ");
                int itemNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                if (itemNumber >= 0 && itemNumber < menuItems.Length)
                {
                    Console.Write($"You selected {menuItems[itemNumber]}\nQuantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    itemPurchased.Add(menuItems[itemNumber]);
                    itemQuantityPurchased.Add(quantity);
                    priceOfItem.Add(menuPrices[itemNumber] * quantity);

                    Console.Write("Do you want to add more items? (Y/N): ");
                    continueOrdering = Console.ReadLine().ToUpper() == "Y";
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
                Console.ReadLine();
            }

            CalculateBill();
        }

        static void ShowMenu()
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i]} - ${menuPrices[i]:0.00}");
            }
        }

        static void CalculateBill()
        {
            Console.WriteLine("\nItems selected by you:");
            double totalBill = 0.0;
            for (int i = 0; i < itemPurchased.Count; i++)
            {
                Console.WriteLine($"{itemQuantityPurchased[i]} x {itemPurchased[i]} - ${priceOfItem[i]:0.00}");
                totalBill += priceOfItem[i];
            }

            Console.WriteLine($"\nTotal Items: {itemPurchased.Count}");
            Console.WriteLine($"Total Bill: ${totalBill:0.00}");
        }
    }
}

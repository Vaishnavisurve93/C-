using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the item from the menu you want to order:\n");
            Console.WriteLine("1. Coffee\n2. Grilled Sandwich\n3. French Fries\n4. Noodles\n5. Pizza\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Coffee\n");
                    break;
                case 2:
                    Console.WriteLine("You selected Grilled Sandwich\n");
                    break;
                case 3:
                    Console.WriteLine("You selected French Fries\n");
                    break;
                case 4:
                    Console.WriteLine("You selected Noodles\n");
                    break;
                case 5:
                    Console.WriteLine("You selected Pizza\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice\n");
                    break;
            }

            Console.WriteLine("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to add more items? (Y/N)");
            char addMore = Convert.ToChar(Console.ReadLine());

            int totalItems = quantity;

            while (addMore == 'Y' || addMore == 'y')
            {
                Console.WriteLine("Select an item to add:");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                totalItems += quantity;

                Console.WriteLine("Do you want to add more items? (Y/N)");
                addMore = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine($"\nItems selected by you: {totalItems} items");
            Console.ReadLine();

        }
    }
}

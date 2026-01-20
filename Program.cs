using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodBankInventory
{
    /// <summary>
    /// Main program class that manages the food bank inventory system
    /// </summary>
    class Program
    {
        // List to store all food items in the inventory
        private static List<FoodItem> inventory = new List<FoodItem>();

        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("   Welcome to Food Bank Inventory System");
            Console.WriteLine("=================================================\n");

            bool running = true;

            // Main program loop
            while (running)
            {
                DisplayMenu();
                int choice = GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        AddFoodItem();
                        break;
                    case 2:
                        DeleteFoodItem();
                        break;
                    case 3:
                        PrintInventory();
                        break;
                    case 4:
                        running = false;
                        Console.WriteLine("\nThank you for using the Food Bank Inventory System!");
                        Console.WriteLine("Goodbye!\n");
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the main menu options
        /// </summary>
        private static void DisplayMenu()
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit Program");
            Console.Write("\nPlease enter your choice (1-4): ");
        }

        /// <summary>
        /// Gets and validates the user's menu choice
        /// </summary>
        /// <returns>Valid menu choice (1-4)</returns>
        private static int GetMenuChoice()
        {
            int choice;
            while (true)
            {
                string input = Console.ReadLine();
                
                // Validate that input is a number
                if (int.TryParse(input, out choice))
                {
                    // Validate that choice is within valid range
                    if (choice >= 1 && choice <= 4)
                    {
                        return choice;
                    }
                }
                
                Console.Write("Invalid choice. Please enter a number between 1 and 4: ");
            }
        }

        /// <summary>
        /// Adds a new food item to the inventory
        /// </summary>
        private static void AddFoodItem()
        {
            Console.WriteLine("\n--- Add New Food Item ---");

            // Get food item name
            Console.Write("Enter food item name: ");
            string name = Console.ReadLine();
            
            // Validate name is not empty
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty. Please enter food item name: ");
                name = Console.ReadLine();
            }

            // Get category
            Console.Write("Enter category (e.g., Canned Goods, Dairy, Produce): ");
            string category = Console.ReadLine();
            
            // Validate category is not empty
            while (string.IsNullOrWhiteSpace(category))
            {
                Console.Write("Category cannot be empty. Please enter category: ");
                category = Console.ReadLine();
            }

            // Get quantity with validation
            int quantity = GetValidQuantity();

            // Get expiration date with validation
            DateTime expirationDate = GetValidDate();

            // Create new food item using constructor
            FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
            
            // Add to inventory list
            inventory.Add(newItem);

            Console.WriteLine($"\n✓ Successfully added '{name}' to inventory!");
        }

        /// <summary>
        /// Gets and validates a positive quantity from the user
        /// </summary>
        /// <returns>Valid positive quantity</returns>
        private static int GetValidQuantity()
        {
            int quantity;
            Console.Write("Enter quantity: ");
            
            while (true)
            {
                string input = Console.ReadLine();
                
                // Check if input is a valid integer
                if (int.TryParse(input, out quantity))
                {
                    // Check if quantity is positive
                    if (quantity > 0)
                    {
                        return quantity;
                    }
                    else
                    {
                        Console.Write("Quantity must be greater than 0. Please enter quantity: ");
                    }
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid number for quantity: ");
                }
            }
        }

        /// <summary>
        /// Gets and validates an expiration date from the user
        /// </summary>
        /// <returns>Valid expiration date</returns>
        private static DateTime GetValidDate()
        {
            DateTime expirationDate;
            Console.Write("Enter expiration date (MM/DD/YYYY): ");
            
            while (true)
            {
                string input = Console.ReadLine();
                
                // Try to parse the date
                if (DateTime.TryParse(input, out expirationDate))
                {
                    return expirationDate;
                }
                else
                {
                    Console.Write("Invalid date format. Please enter date (MM/DD/YYYY): ");
                }
            }
        }

        /// <summary>
        /// Deletes a food item from the inventory
        /// </summary>
        private static void DeleteFoodItem()
        {
            Console.WriteLine("\n--- Delete Food Item ---");

            // Check if inventory is empty
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty. Nothing to delete.");
                return;
            }

            // Display current inventory with numbers
            Console.WriteLine("\nCurrent Inventory:");
            Console.WriteLine(new string('-', 75));
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
            Console.WriteLine(new string('-', 75));

            // Get item number to delete
            Console.Write($"\nEnter the number of the item to delete (1-{inventory.Count}), or 0 to cancel: ");
            
            int choice;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out choice))
                {
                    // Check if user wants to cancel
                    if (choice == 0)
                    {
                        Console.WriteLine("Delete cancelled.");
                        return;
                    }
                    
                    // Validate choice is in range
                    if (choice >= 1 && choice <= inventory.Count)
                    {
                        break;
                    }
                }
                
                Console.Write($"Invalid choice. Please enter a number between 1 and {inventory.Count} (or 0 to cancel): ");
            }

            // Remove the item
            string deletedItemName = inventory[choice - 1].Name;
            inventory.RemoveAt(choice - 1);
            
            Console.WriteLine($"\n✓ Successfully deleted '{deletedItemName}' from inventory!");
        }

        /// <summary>
        /// Prints the complete inventory list
        /// </summary>
        private static void PrintInventory()
        {
            Console.WriteLine("\n--- Current Food Inventory ---");

            // Check if inventory is empty
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is currently empty.");
                return;
            }

            Console.WriteLine(new string('=', 75));
            Console.WriteLine($"{"Food Item",-25} | {"Category",-15} | {"Quantity",8} | Expiration");
            Console.WriteLine(new string('=', 75));

            // Print each food item
            foreach (FoodItem item in inventory)
            {
                // Add warning for expired items
                string expiredWarning = item.IsExpired() ? " ⚠ EXPIRED" : "";
                Console.WriteLine(item.ToString() + expiredWarning);
            }

            Console.WriteLine(new string('=', 75));
            Console.WriteLine($"Total Items: {inventory.Count}");
            
            // Show count of expired items
            int expiredCount = inventory.Count(item => item.IsExpired());
            if (expiredCount > 0)
            {
                Console.WriteLine($"⚠ Warning: {expiredCount} expired item(s) need attention!");
            }
        }
    }
}

using System;

namespace FoodBankInventory
{
    /// <summary>
    /// Represents a food item in the food bank inventory
    /// </summary>
    public class FoodItem
    {
        // Properties to store food item information
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Constructor to initialize a food item with all required information
        /// </summary>
        /// <param name="name">Name of the food item</param>
        /// <param name="category">Category of the food item</param>
        /// <param name="quantity">Quantity in units</param>
        /// <param name="expirationDate">Expiration date</param>
        public FoodItem(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Returns a formatted string representation of the food item
        /// </summary>
        public override string ToString()
        {
            return $"{Name,-25} | {Category,-15} | Qty: {Quantity,4} | Expires: {ExpirationDate.ToShortDateString()}";
        }

        /// <summary>
        /// Checks if the food item is expired
        /// </summary>
        public bool IsExpired()
        {
            return ExpirationDate < DateTime.Now;
        }
    }
}

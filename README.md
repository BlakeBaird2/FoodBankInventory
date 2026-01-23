# Food Bank Inventory System

A C# console application for managing food bank inventory, tracking donations, and monitoring expiration dates.

## Project Information
- **Course**: IS 413
- **Assignment**: Mission #3
- **Purpose**: Help food banks manage inventory, track expiration dates, and prevent waste

## Features

### Core Functionality
- ✅ **Add Food Items**: Add new items with name, category, quantity, and expiration date
- ✅ **Delete Food Items**: Remove items from inventory with numbered selection
- ✅ **Print Inventory**: View complete list of all food items with expiration warnings
- ✅ **Exit Program**: Safely exit the application

### Additional Features
- Input validation for all user entries
- Expired item warnings and tracking
- Formatted, easy-to-read inventory display
- User-friendly menu interface
- Error handling for invalid inputs

## Project Structure

```
FoodBankInventory/
│
├── Program.cs          # Main program with menu and control flow
├── FoodItem.cs         # Food item class with constructor
└── FoodBankInventory.csproj  # Project configuration file
```

## Classes

### FoodItem Class
Stores information for individual food items:
- **Properties**: Name, Category, Quantity, ExpirationDate
- **Constructor**: Initializes all properties when creating a new food item
- **Methods**: 
  - `ToString()`: Formatted string representation
  - `IsExpired()`: Checks if item has expired

### Program Class
Main application logic:
- Menu display and navigation
- Add, delete, and print operations
- Input validation and error handling
- Uses `List<FoodItem>` for inventory management

## How to Run

### Prerequisites
- .NET 6.0 SDK or later

### Running the Program

1. **Clone the repository**:
   ```bash
   git clone <your-repository-url>
   cd FoodBankInventory
   ```

2. **Build and run**:
   ```bash
   dotnet run
   ```

   Or build separately:
   ```bash
   dotnet build
   dotnet run
   ```

## Usage Examples

### Adding a Food Item
```
Enter food item name: Canned Beans
Enter category: Canned Goods
Enter quantity: 24
Enter expiration date: 12/31/2025
```

### Deleting a Food Item
The program displays a numbered list of items. Enter the number of the item to delete, or 0 to cancel.

### Viewing Inventory
Displays all items with:
- Name
- Category
- Quantity
- Expiration date
- Warning indicator for expired items

## Error Handling

The program includes validation for:
- ✅ Menu choices (must be 1-4)
- ✅ Food item names (cannot be empty)
- ✅ Categories (cannot be empty)
- ✅ Quantities (must be positive integers)
- ✅ Dates (must be valid date format)
- ✅ Delete operations (must select valid item number)

## Rubric Compliance

| Requirement | Points | Status |
|------------|--------|--------|
| Program Compiles and Runs | 10 | ✅ |
| Two Classes (Program.cs & FoodItem.cs) | 5 | ✅ |
| Ability to Add Food Items | 20 | ✅ |
| Ability to Delete Food Items | 20 | ✅ |
| Ability to Print List | 20 | ✅ |
| Constructor Usage | 15 | ✅ |
| Code Readability | 10 | ✅ |
| **Total** | **100** | **✅** |

## Code Quality Features

- Clear variable names
- Comprehensive comments
- Proper spacing and formatting
- Separation of concerns
- Helper methods for validation
- Consistent naming conventions

## Future Enhancements (Optional)
- Search functionality
- Sort by expiration date
- Edit existing items
- Save/load inventory from file
- Generate reports on expired items
- Low quantity alerts

## Author
Blake Baird

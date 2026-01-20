# Submission Guide for Mission #3

## ✅ Pre-Submission Checklist

Before submitting, verify:
- [ ] Program compiles without errors
- [ ] All menu options work correctly
- [ ] Error handling works for invalid inputs
- [ ] GitHub repository is set to **PUBLIC**
- [ ] All files are committed and pushed

## Testing Your Program

### 1. Compile and Run Test
```bash
cd FoodBankInventory
dotnet build
dotnet run
```

**Expected Result**: Program should compile without errors and display the welcome message and menu.

### 2. Test Add Functionality (20 points)

**Test Case 1: Valid Input**
- Choose option 1
- Enter: "Canned Beans"
- Enter: "Canned Goods"
- Enter: 15
- Enter: 12/31/2025
- ✅ Should successfully add item

**Test Case 2: Invalid Quantity**
- Choose option 1
- Try entering: -5 or 0
- ✅ Should prompt for valid positive number

**Test Case 3: Empty Name**
- Choose option 1
- Press Enter without typing a name
- ✅ Should prompt for a valid name

### 3. Test Print Functionality (20 points)

- Choose option 3
- ✅ Should display all items in formatted table
- ✅ Should show "Inventory is currently empty" if no items

**Test with multiple items:**
- Add 3-4 different items
- Choose option 3
- ✅ Should display all items clearly

### 4. Test Delete Functionality (20 points)

**Test Case 1: Valid Delete**
- Add several items
- Choose option 2
- Select a valid item number
- ✅ Should remove the item
- Print inventory to verify

**Test Case 2: Invalid Selection**
- Choose option 2
- Enter an invalid number (e.g., 999)
- ✅ Should prompt for valid selection

**Test Case 3: Cancel Delete**
- Choose option 2
- Enter 0
- ✅ Should cancel without deleting

**Test Case 4: Empty Inventory**
- Delete all items
- Choose option 2
- ✅ Should display "Inventory is empty"

### 5. Test Exit Functionality
- Choose option 4
- ✅ Should display goodbye message and exit

### 6. Test Error Handling

**Menu Error Handling:**
- Enter letters instead of numbers
- Enter numbers outside 1-4
- ✅ Should prompt for valid input

### 7. Test Expired Items Feature (Bonus)
- Add an item with past date (e.g., 01/01/2024)
- Print inventory
- ✅ Should show ⚠ EXPIRED warning

## GitHub Setup

### Step 1: Create Repository
1. Go to https://github.com
2. Click "New Repository"
3. Name it: `FoodBankInventory` or `IS413-Mission3`
4. **IMPORTANT**: Select "Public" (not Private!)
5. Do NOT initialize with README (you already have one)
6. Click "Create repository"

### Step 2: Push Your Code

From your project directory:
```bash
# Initialize git (if not already done)
git init

# Add all files
git add .

# Make your first commit
git commit -m "Initial commit - Food Bank Inventory System"

# Add remote repository (use YOUR repository URL)
git remote add origin https://github.com/YOUR-USERNAME/FoodBankInventory.git

# Push to GitHub
git branch -M main
git push -u origin main
```

### Step 3: Verify Repository is Public
1. Go to your repository on GitHub
2. Look for "Public" badge next to repository name
3. If it says "Private":
   - Click "Settings"
   - Scroll to "Danger Zone"
   - Click "Change visibility"
   - Select "Make public"

### Step 4: Get Submission Link
Your submission link should look like:
```
https://github.com/YOUR-USERNAME/FoodBankInventory
```

## Rubric Self-Check

| Criterion | Points | Self-Check |
|-----------|--------|------------|
| Program compiles and runs | 10 | □ Tested with `dotnet run` |
| Two separate classes | 5 | □ Program.cs and FoodItem.cs exist |
| Add food items works | 20 | □ Tested adding multiple items |
| Delete food items works | 20 | □ Tested deleting items |
| Print list works | 20 | □ Tested printing inventory |
| Constructor used in FoodItem | 15 | □ Constructor sets all properties |
| Code is readable | 10 | □ Comments, good names, spacing |
| **Total** | **100** | |

## Common Issues to Avoid

### ❌ Private Repository (Automatic -20%)
- **Problem**: Repository set to Private
- **Solution**: Change to Public in Settings

### ❌ Files Not Pushed
- **Problem**: Files only on local computer
- **Solution**: Use `git push` to upload to GitHub

### ❌ Wrong File Structure
- **Problem**: Classes in same file
- **Solution**: Separate Program.cs and FoodItem.cs

### ❌ No Error Handling
- **Problem**: Program crashes on invalid input
- **Solution**: Use try-catch or input validation

### ❌ Constructor Not Used
- **Problem**: Setting properties directly
- **Solution**: Use constructor to initialize FoodItem

## Final Submission

1. ✅ Run all tests above
2. ✅ Verify GitHub repo is PUBLIC
3. ✅ Copy your GitHub URL
4. ✅ Submit on Learning Suite

## Need Help?

If you encounter issues:
1. Check error messages carefully
2. Verify all files are in correct locations
3. Make sure .NET SDK is installed
4. Review the rubric requirements
5. Ask on Slack if stuck

## Sample Test Session

Here's what a successful test session looks like:

```
=================================================
   Welcome to Food Bank Inventory System
=================================================

--- Main Menu ---
1. Add Food Item
2. Delete Food Item
3. Print List of Current Food Items
4. Exit Program

Please enter your choice (1-4): 1

--- Add New Food Item ---
Enter food item name: Canned Corn
Enter category: Canned Goods
Enter quantity: 20
Enter expiration date (MM/DD/YYYY): 06/30/2026

✓ Successfully added 'Canned Corn' to inventory!

--- Main Menu ---
1. Add Food Item
2. Delete Food Item
3. Print List of Current Food Items
4. Exit Program

Please enter your choice (1-4): 3

--- Current Food Inventory ---
===========================================================================
Food Item                 | Category        | Quantity | Expiration
===========================================================================
Canned Corn               | Canned Goods    | Qty:   20 | Expires: 6/30/2026
===========================================================================
Total Items: 1
```

Good luck! 🎯

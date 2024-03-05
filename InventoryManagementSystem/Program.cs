public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        //Initializing the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"The price of {ItemName} is now {Price}"); //Update the item's price with the new price.
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.

        Console.WriteLine($"Enter the number of {ItemName} to restock: ");
        additionalQuantity = int.Parse(Console.ReadLine());

        if( additionalQuantity >= 0 )
        {
            QuantityInStock += additionalQuantity;
            Console.WriteLine($"{additionalQuantity} number of units have been added to {ItemName}. Number of units in stock is now {QuantityInStock}");
        }
        else
        {
            Console.WriteLine("enter a valid number of additional quantiy to be added");
        }

    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.

        Console.WriteLine($"Enter the number of {ItemName} you want to sell: ");
        quantitySold = int.Parse(Console.ReadLine());

        if (quantitySold <= QuantityInStock)//if the amount of unit requested for is less than or equal to the units in stock, proceed with the sale
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"Congratulations, you have successfully sold {quantitySold} units.");
        }
        else if (quantitySold <= 0)
        {
            Console.WriteLine("enter a valid input of units to sell");
        }
        else
        {
            Console.WriteLine("You don't have sufficient units to sell. Go and restock first"); //check to ensure stock quantity is not negative
        }
        
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Name of Item: {ItemName}, item ID: {ItemId}, item Price: {Price}, Stock Quantity: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);


        // 1. Print details of all items.
        Console.WriteLine("Current inventory item details are:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        Console.WriteLine("How the sales process works");
        item1.SellItem(4);
        item2.SellItem(5);

        Console.WriteLine();

        item1.PrintDetails();
        item2.PrintDetails();

        Console.WriteLine();

        // 3. Restock an item and print the updated details.
        Console.WriteLine("You want to restock on goods");
        item1.RestockItem(2);
        item2.RestockItem(2);

        Console.WriteLine();

        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();


        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("Checking if an item is in stock");
        Console.WriteLine($"Item 1 ({item1.ItemName}) is{(item1.IsInStock() ? "" : " not")} in stock.");
        Console.WriteLine($"Item 2 ({item2.ItemName}) is{(item2.IsInStock() ? "" : " not")} in stock.");

    }
}

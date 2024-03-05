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
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"{additionalQuantity} number of units have been added to {ItemName}");
        // TODO: Increase the item's stock quantity by the additional quantity.
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock)//if the amount of unit requested for is less than or equal to the units in stock, proceed with the sale
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"Congratulations, you have successfully sold {quantitySold} units.");
        }
        else
        {
            Console.WriteLine("You don't have sufficient units to sell"); //check to ensure stock quantity is not negative

        }
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Name of Item: {ItemName}, item ID: {ItemId}, item Price: {Price}, Stock Quantity: {QuantityInStock}");
        // TODO: Print the details of the item (name, id, price, and stock quantity).
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.

        item1.PrintDetails();
        item2.PrintDetails();

        // 2. Sell some items and then print the updated details.

        item1.SellItem(4);
        item2.SellItem(5);
        item1.PrintDetails();
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.

        item1.RestockItem(4);
        item2.RestockItem(2);
        item1.PrintDetails();
        item2.PrintDetails();


        // 4. Check if an item is in stock and print a message accordingly.


    }
}

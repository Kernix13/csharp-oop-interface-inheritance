
// public class Product : IInventoryItem

namespace InventorySystem;

public class Product : IInventoryItem
{
    // You must implement everything the interface asked for
    public string ItemNumber { get; set; } = "ABC123";
    public int QuantityOnHand { get; set; } = 97;
    public int QuantityOnOrder { get; set; } = 250;
    public int QuantityOnBackOrder { get; set; } = 0;

    // Base Constructor
    public Product(string itemNumber, int onHand, int onOrder, int onBackOrder)
    {
        ItemNumber = itemNumber;
        QuantityOnHand = onHand;
        QuantityOnOrder = onOrder;
        QuantityOnBackOrder = onBackOrder;
    }

    public virtual string DisplayItemInfo()
    {
        return $"Item Number: {ItemNumber}, Quantity On Hand: {QuantityOnHand}, Quantity On Order: {QuantityOnOrder}, Quantity On Back Order: {QuantityOnBackOrder}";
    }
}
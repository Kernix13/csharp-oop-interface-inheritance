namespace InventorySystem;

public class Product : IInventoryItem
{
    // You must implement everything the interface asked for
    public string ItemNumber { get; set; }
    public int QuantityOnHand { get; set; }
    public int QuantityOnOrder { get; set; }
    public int QuantityOnBackOrder { get; set; }

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
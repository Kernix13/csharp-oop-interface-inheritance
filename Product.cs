
// public class Product : IInventoryItem

namespace InventorySystem;

public class Product
{
    public string ItemNumber = "ABC123";
    public int QuantityOnHand = 97;
    public int QuantityOnOrder = 250;
    public int QuantityOnBackOrder = 0;

    public virtual string DisplayItemInfo()
    {
        return $"Item Number: {ItemNumber}, Quantity On Hand: {QuantityOnHand}, Quantity On Order: {QuantityOnOrder}, Quantity On Back Order: {QuantityOnBackOrder}";
    }
}
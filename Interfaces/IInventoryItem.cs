namespace InventorySystem;

public interface IInventoryItem
{
    public string ItemNumber { get; set; }
    public int QuantityOnHand { get; set; }
    public int QuantityOnOrder { get; }
    public int QuantityOnBackOrder { get; set; }

    // void UpdateStock(int amount);

    string DisplayItemInfo();
}
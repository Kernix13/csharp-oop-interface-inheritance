namespace InventorySystem;

public interface IInventoryItem
{
    string ItemNumber { get; set; }
    int QuantityOnHand { get; set; }
    int QuantityOnOrder { get; }
    int QuantityOnBackOrder { get; set; }

    // void UpdateStock(int amount);
}
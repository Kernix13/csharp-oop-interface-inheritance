namespace InventorySystem;

// public abstract class Product : IInventoryItem
public abstract class Product
{
    // fields and constructors here
    // use virtual so DatedProduct can change
    string? ItemNumber;
    int QuantityOnHand;
    int QuantityOnOrder;
    int QuantityOnBackOrder;
}
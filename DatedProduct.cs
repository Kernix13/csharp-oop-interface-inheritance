// fields and constructors here
// use override to provide the new logic for the virtual method
// use protected for a field like _baseCost so that derived classes can see it, but the "Main" program cannot

namespace InventorySystem;

public class DatedProduct : Product
{

    public DatedProduct(string itemNumber, int onHand, int onOrder, int onBackOrder)
        : base(itemNumber, onHand, onOrder, onBackOrder) { }

    public override string DisplayItemInfo()
    {
        return $"Item Number: {ItemNumber}, Quantity On Hand: {QuantityOnHand}";
    }
}
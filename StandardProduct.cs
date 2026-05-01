namespace InventorySystem;

public class StandardProduct : Product
{

    public StandardProduct(string itemNumber, int onHand, int onOrder, int onBackOrder)
        : base(itemNumber, onHand, onOrder, onBackOrder)
    {
        // You don't need to write any code inside the brackets { }
        // because the base constructor already handled it!
    }

    public override string DisplayItemInfo()
    {
        return $"[Standard] Item: {ItemNumber}, Stock: {QuantityOnHand}";
    }
}
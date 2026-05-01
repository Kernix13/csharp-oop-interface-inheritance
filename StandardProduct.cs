namespace InventorySystem;

public class StandardProduct : Product
{

    public override string DisplayItemInfo()
    {
        return $"[Standard] Item: {ItemNumber}, Stock: {QuantityOnHand}";
    }
}